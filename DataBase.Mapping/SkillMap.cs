using DashaLearning.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Mapping
{
    public class SkillMap : ColumnMapping<Skill>
    {
        public SkillMap()
        {
            HasTableName("skills");
            Map(p => p.Id).ToColumn("id");
            Map(p => p.Name).ToColumn("name");
            Map(p => p.Description).ToColumn("description");
        }
    }
}
