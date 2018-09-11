using DashaLearning.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Mapping
{
    public class PersonsItemMap : ColumnMapping<PersonsItem>
    {
        public PersonsItemMap()
        {
            HasTableName("items_persons");
            Map(p => p.Id).ToColumn("id");
            Map(p => p.PersonId).ToColumn("person_id");
            Map(p => p.ItemId).ToColumn("item_id");
            Map(p => p.Count).ToColumn("count");
        }
    }
}
