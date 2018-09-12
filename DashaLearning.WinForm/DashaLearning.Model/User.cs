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
        /// Конструктор класса Пользователь
        /// </summary>
        public User()
        {
            Persons = new List<Person>();
        }
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Статус
        /// </summary>
        public bool IsOnline { get; set; }
        /// <summary>
        /// Последнее посещение
        /// </summary>
        public DateTime LastOnlineDate { get; set; }
        /// <summary>
        /// список Персонажей пользователя
        /// </summary>
        public List<Person> Persons { get; set; }
    }
}
