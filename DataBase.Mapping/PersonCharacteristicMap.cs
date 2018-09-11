using DashaLearning.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Mapping
{
    public class PersonCharacteristicMap : ColumnMapping<PersonCharacteristic>
    {
        public PersonCharacteristicMap()
        {
            HasTableName("person_characteristics");
            Map(p => p.Id).ToColumn("id");
            Map(p => p.PersonId).ToColumn("person_id");
            Map(p => p.MaxHp).ToColumn("max_hp");
            Map(p => p.MaxMana).ToColumn("max_mana");
            Map(p => p.Experience).ToColumn("experience");
            Map(p => p.Level).ToColumn("level");
        }
    }
}
