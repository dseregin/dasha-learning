using DashaLearning.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Mapping
{
    public class UserMap : ColumnMapping<User>
    {
        public UserMap()
        {
            HasTableName("users");
            Map(p => p.Id).ToColumn("id");
            Map(p => p.Login).ToColumn("login");
            Map(p => p.Password).ToColumn("password");
            Map(p => p.IsOnline).ToColumn("is_online");
            Map(p => p.LastOnlineDate).ToColumn("last_online_date");
        }
    }
}
