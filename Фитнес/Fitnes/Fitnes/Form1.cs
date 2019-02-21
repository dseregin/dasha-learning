using Fitnes.Repositories;
using System;
using System.Windows.Forms;

namespace Fitnes
{
    public partial class Form1 : Form
    {
        private DayRepository _dayRepository;
        private GymExerciseRepository _gymExerciseRepository;

        public Form1()
        {
            InitializeComponent();
            InitializeRepositories();
        }

        private void InitializeRepositories()
        {
            _dayRepository = new DayRepository();
            _gymExerciseRepository = new GymExerciseRepository();
        }

        #region buttons
        private void buttonAddDay_Click(object sender, EventArgs e)
        {
            DayDataGridView.Visible = false;
            if (DateTime.TryParse(textBoxDate.Text, out DateTime date))
            {
                _dayRepository.AddDay(new Models.Day { Id = Guid.NewGuid(), Date = date, Calories = 0 });
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(textBoxDate.Text, out DateTime date))
            {
                DayDataGridView.Rows.Clear();

                var day = _dayRepository.GetDayInformationByDate(date);

                DayDataGridView.Visible = true;

                var rowsCount = day.DayTrainingCapasities.Count;

                foreach (var dtc in day.DayTrainingCapasities)
                {
                    DayDataGridView["ExName", 0].Value = dtc.ExerciseCapasity.GymExercise.Name;
                    DayDataGridView["SetCount", 0].Value = dtc.ExerciseCapasity.Capasity.SetsCount;
                    DayDataGridView["repitCount", 0].Value = dtc.ExerciseCapasity.Capasity.RepetitionsCount + " " + dtc.ExerciseCapasity.Capasity.RepetitionsCountUnitType.Name;
                    DayDataGridView["Capasity", 0].Value = dtc.ExerciseCapasity.Capasity.Value + " " + dtc.ExerciseCapasity.Capasity.ValueUnit.Name;

                    rowsCount--;

                    if (rowsCount != 0)
                        DayDataGridView.Rows.Add();
                }
            }
        }

        #endregion


    }
}
