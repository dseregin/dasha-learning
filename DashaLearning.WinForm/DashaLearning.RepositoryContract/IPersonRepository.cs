using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashaLearning.Model;

namespace DashaLearning.RepositoryContract
{
    public interface IPersonRepository
    {
        /// <summary>
        /// получение данных персонажа без ссылок
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Person> GetPersonByIdLite(Guid id);
        /// <summary>
        /// Получение всех персонажей
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Person>> GetAllPersonsLite();
    }
}
