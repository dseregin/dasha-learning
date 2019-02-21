using Fitnes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fitnes.Repositories
{
    public class DayRepository : BaseRepository
    {
        public DayRepository() : base()
        {
        }

        public List<Day> GetAllDays()
        {
            return _fitnesDataBase.Days.Include(d => d.DayTrainingCapasities).ToList();
        }

        public bool AddDay(Day day)
        {
            var allDays = _fitnesDataBase.Days.ToList();
            if (allDays.Any(d => d.Date.Date == day.Date.Date))
            {
                return false;
            }
            else
            {
                _fitnesDataBase.Days.Add(day);
                _fitnesDataBase.SaveChanges();

                return true;
            }
        }

        public Day GetDayInformationByDate(DateTime dateTime)
        {
            var day = _fitnesDataBase.Days
                .Include(d => d.DayTrainingCapasities)
                .Include(d => d.DayTrainingCapasities.Select(dtc => dtc.ExerciseCapasity))
                .Include(d => d.DayTrainingCapasities.Select(dtc => dtc.ExerciseCapasity.GymExercise))
                .Include(d => d.DayTrainingCapasities.Select(dtc => dtc.ExerciseCapasity.Capasity))
                .FirstOrDefault(d => d.Date == dateTime.Date);

            //как сохранить информацию о дней в рамках одной транзакции
            //_fitnesDataBase.Capasities.Add(new Capasity());
            //_fitnesDataBase.ExerciseCapasities.Add(new ExerciseCapasity());
            //_fitnesDataBase.Days.Add(new Day());
            //_fitnesDataBase.DayTrainingCapasities.Add(new DayTrainingCapasity());

            //_fitnesDataBase.SaveChanges();

            return day;
        }
    }
}
