using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitnes.Models
{
    [Table("day")]
    public class Day
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("calories")]
        public int Calories { get; set; }

        public virtual ICollection<DayTrainingCapasity> DayTrainingCapasities { get; set; }

        public Day()
        {
            DayTrainingCapasities = new List<DayTrainingCapasity>();
        }
    }
}
