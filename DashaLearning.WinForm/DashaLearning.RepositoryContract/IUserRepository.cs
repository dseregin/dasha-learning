using DashaLearning.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashaLearning.RepositoryContract
{
    public interface IUserRepository
    {
        /// <summary>
        /// получение данных пользователя
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<User> GetUserByIdLite(Guid id);
        /// <summary>
        /// получение данных пользователя и персов
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<User> GetUserById(Guid id);
        /// <summary>
        /// Получение всех пользователей
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<User>> GetAllUsersLite();
    }
}
