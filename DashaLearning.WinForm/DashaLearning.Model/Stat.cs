using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashaLearning.Model
{
    public class Stat
    {
        public Guid Id { get; set; }
        public int IntellectValue { get; set; }
        public int AgilityValue { get; set; }
        public int StrenghtValue { get; set; }

        #region person
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
        #endregion

    }
}
