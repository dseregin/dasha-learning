using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnes.Models
{
    [Table("training_type")]
    public class TrainingType
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public virtual ICollection<GymExercise> GymExercises { get; set; }

        public TrainingType()
        {
            GymExercises = new List<GymExercise>();
        }
    }
}
