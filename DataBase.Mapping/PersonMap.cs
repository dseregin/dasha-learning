using DashaLearning.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Mapping
{
    public class PersonMap : ColumnMapping<Person>
    {
        public PersonMap()
        {
            HasTableName("persons");
            Map(p => p.Id).ToColumn("id");
            Map(p => p.UserId).ToColumn("user_id");
            Map(p => p.Name).ToColumn("name");
            Map(p => p.Male).ToColumn("male");
            Map(p => p.ClassId).ToColumn("class_id");
        }
    }
}
