using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnes.Models
{
    [Table("gym_exercises")]
    public class GymExercise
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("training_type_id")]
        public Guid TrainingTypeId { get; set; }

        public virtual TrainingType TrainingType { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public virtual ICollection<ExerciseCapasity> ExerciseCapasities { get; set; }

        public GymExercise()
        {
            ExerciseCapasities = new List<ExerciseCapasity>();
        }
    }
}
