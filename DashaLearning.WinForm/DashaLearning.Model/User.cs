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
        /// Свойство получает/задает значение Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Логин
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Пароль
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Статус
        /// </summary>
        public bool IsOnline { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Последнее посещение
        /// </summary>
        public DateTime LastOnlineDate { get; set; }
        /// <summary>
        /// Свойство получает/задает список Персонажи
        /// </summary>
        public List<Person> Persons { get; set; }
    }
}
