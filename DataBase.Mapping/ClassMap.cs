using DashaLearning.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Mapping
{
    public class ClassMap : ColumnMapping<Class>
    {
        public ClassMap()
        {
            HasTableName("classes");
            Map(p => p.Id).ToColumn("id");
            Map(p => p.Name).ToColumn("name");
            Map(p => p.SomeCharacteristics).ToColumn("some_characteristics");
        }
    }
}
