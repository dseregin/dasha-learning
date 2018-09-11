using DashaLearning.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Mapping
{
    public class TypeMap : ColumnMapping<DashaLearning.Model.Type>
    {
        public TypeMap()
        {
            HasTableName("types");
            Map(p => p.Id).ToColumn("id");
            Map(p => p.Name).ToColumn("name");
        }
    }
}
