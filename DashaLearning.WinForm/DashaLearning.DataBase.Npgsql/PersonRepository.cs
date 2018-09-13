using DashaLearning.Model;
using DashaLearning.RepositoryContract;
using DataBase.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashaLearning.DataBase.Npgsql
{
    public class PersonRepository : BaseRepository, IPersonRepository
    {
        private ColumnMapping<Person> _personMap;
        static PersonRepository()
        {
            ColumnMapping.Initialize(c =>
            {
                c.AddMap(new PersonMap());
            });
        }
        public async Task<Person> GetPersonByIdLite(Guid id)
        {
            var query = $@"select {_personMap.ForAllProps()}
                            from {_personMap.TableName}
                            where {_personMap.ColumnName(c => c.Id)} = '{id}'";

            var result = await GetAwaitableDataCollectionLoader<Person>(query);

            return result.FirstOrDefault();
        }
        public async Task<IEnumerable<Person>> GetAllPersonsLite()
        {
            var query = $@"select {_personMap.ForAllProps()}
                        from {_personMap.TableName}";

            var persons = await GetAwaitableDataCollectionLoader<Person>(query);
            return persons;
        }
    }
}