using System;
using System.Collections.Generic;

namespace DashaLearning.Model
{
    /// <summary>
    /// Класс Пользователь
    /// </summary>
    public class User
    {
        /// <summary>
        /// 
        /// </summary>
        public User()
        {
            Persons = new List<Person>();
        }

        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsOnline { get; set; }
        public DateTime LastOnlineDate { get; set; }
        public List<Person> Persons { get; set; }
    }
}
