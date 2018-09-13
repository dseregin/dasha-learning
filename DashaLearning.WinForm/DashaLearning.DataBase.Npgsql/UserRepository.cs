using DashaLearning.Model;
using DashaLearning.RepositoryContract;
using DataBase.Mapping;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashaLearning.DataBase.Npgsql
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        private ColumnMapping<User> _userMap;
        private ColumnMapping<Person> _personMap;

        static UserRepository()
        {
            ColumnMapping.Initialize(c =>
            {
                c.AddMap(new UserMap());
                c.AddMap(new PersonMap());
            });
        }

        public UserRepository() : base()
        {
            _userMap = ColumnMapping.GetFor<User>();
            _personMap = ColumnMapping.GetFor<Person>();

        }

        public async Task<User> GetUserById(Guid id)
        {
            var query = $@"select {_userMap.ForAllProps("u")}, {_personMap.ForAllProps("p")}
                            from {_userMap.TableName} as u
                            left join {_personMap.TableName} as p
                                on u.{_userMap.ColumnName(c => c.Id)} = p.{_personMap.ColumnName(c => c.UserId)}
                            where u.{_userMap.ColumnName(c => c.Id)} = '{id}'";

            User user = null;

            var result = await GetAwaitableDataCollectionLoader<User, Person, User>(query, (u, p) =>
            {
                if (u != null && user == null)
                {
                    user = u;
                }
                if (p != null)
                {
                    user.Persons.Add(p);
                }
                return u;
            });
            return result.FirstOrDefault();
        }

        public async Task<User> GetUserByIdLite(Guid id)
        {
            var query = $@"select {_userMap.ForAllProps()}
                            from {_userMap.TableName}
                            where {_userMap.ColumnName(c => c.Id)} = '{id}'";

            var result = await GetAwaitableDataCollectionLoader<User>(query);

            return result.FirstOrDefault();
        }

        public async Task<IEnumerable<User>> GetAllUsersLite()
        {
            var query = $@"select {_userMap.ForAllProps()}
                        from {_userMap.TableName}";

            var users = await GetAwaitableDataCollectionLoader<User>(query);
            return users;
        }
    }
}
