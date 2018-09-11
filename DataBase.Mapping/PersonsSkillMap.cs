using DashaLearning.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Mapping
{
    public class PersonsSkillMap : ColumnMapping<PersonsSkill>
    {
        public PersonsSkillMap()
        {
            HasTableName("persons_skills");
            Map(p => p.Id).ToColumn("id");
            Map(p => p.PersonId).ToColumn("person_id");
            Map(p => p.SkillId).ToColumn("skill_id");
            Map(p => p.PowerValue).ToColumn("power_value");
        }
    }
}
