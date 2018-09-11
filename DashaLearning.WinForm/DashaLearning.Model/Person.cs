using System;
using System.Collections.Generic;

namespace DashaLearning.Model
{
    /// <summary>
    /// Класс Персонаж
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Конструктор класса Персонаж
        /// </summary>
        public Person()
        {
            PersonsSkills = new List<PersonsSkill>();
        }
        /// <summary>
        /// Свойство получает/задает значение Id
        /// </summary>
        public Guid Id { get; set; }
        #region User
        /// <summary>
        /// Свойство получает/задает значение Id Пользователь
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Пользователь
        /// </summary>
        public User User { get; set; }
        #endregion
        /// <summary>
        /// Свойство получает/задает значение Имя персонажа
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Пол
        /// </summary>
        public bool Male { get; set; }
        #region Class
        /// <summary>
        /// Свойство получает/задает значение Id Класса
        /// </summary>
        public Guid ClassId { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Класс
        /// </summary>
        public Class Class { get; set; }
        #endregion
        /// <summary>
        /// Свойство получает/задает значение Стат
        /// </summary>
        public Stat Stat { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Характеристики персонажа
        /// </summary>
        public PersonCharacteristic PersonCharacteristic { get; set; }
        /// <summary>
        /// Свойство получает/задает список Скиллы персонажа
        /// </summary>
        public List<PersonsSkill> PersonsSkills { get; set; }
    }
}
