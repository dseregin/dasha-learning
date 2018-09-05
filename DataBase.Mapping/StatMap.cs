using DashaLearning.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Mapping
{
    public class StatMap : ColumnMapping<Stat>
    {
        public StatMap()
        {
            HasTableName("stats");
            Map(p => p.Id).ToColumn("id");
            Map(p => p.IntellectValue).ToColumn("intellect_value");
            Map(p => p.AgilityValue).ToColumn("agility_value");
            Map(p => p.StrenghtValue).ToColumn("strenght_value");
            Map(p => p.PersonId).ToColumn("person_id");
        }
    }
}
