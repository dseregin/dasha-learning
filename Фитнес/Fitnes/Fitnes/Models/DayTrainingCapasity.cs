using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnes.Models
{
    [Table("day_training_capasity")]
    public class DayTrainingCapasity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("day_id")]
        public Guid DayId { get; set; }
        public virtual Day Day { get; set; }

        [Column("exercise_capasity_id")]
        public int ExerciseCapasityId { get; set; }
        public virtual ExerciseCapasity ExerciseCapasity { get; set; }
    }
}
