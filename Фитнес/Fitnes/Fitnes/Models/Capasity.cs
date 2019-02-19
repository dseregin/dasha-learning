using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnes.Models
{
    [Table("capasity")]
    public class Capasity
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("sets_count")]
        public int SetsCount { get; set; }

        [Column("repetitions_count")]
        public int RepetitionsCount { get; set; }

        [Column("result_count")]
        public int ResultCount { get; set; }

        [Column("repetitions_count_unit_type_id")]
        public Guid RepetitionsCountUnitTypeId { get; set; }
        public virtual UnitType RepetitionsCountUnitType { get; set; }

        [Column("result_count_unit_id")]
        public Guid ResultCountUnitId { get; set; }
        public virtual UnitType ResultCountUnit { get; set; }

        public virtual ICollection<ExerciseCapasity> ExerciseCapasities { get; set; }

        public Capasity()
        {
            ExerciseCapasities = new List<ExerciseCapasity>();
        }
    }
}
