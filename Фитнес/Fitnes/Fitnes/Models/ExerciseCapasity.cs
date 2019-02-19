using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnes.Models
{
    [Table("gym_exercises_capasity")]
    public class ExerciseCapasity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("gym_exercise_id")]
        public Guid GymExerciseId { get; set; }
        public virtual GymExercise GymExercise { get; set; }

        [Column("capasity_id")]
        public Guid CapasityId { get; set; }
        public virtual Capasity Capasity { get; set; }
    }
}
