using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
