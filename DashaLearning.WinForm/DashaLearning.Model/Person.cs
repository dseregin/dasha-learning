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
        /// Id
        /// </summary>
        public Guid Id { get; set; }

        #region User
        /// <summary>
        /// Id Пользователь
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public User User { get; set; }
        #endregion

        /// <summary>
        /// Имя персонажа
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public bool Male { get; set; }

        #region Class
        /// <summary>
        /// Id Класса
        /// </summary>
        public Guid ClassId { get; set; }
        /// <summary>
        /// Класс
        /// </summary>
        public Class Class { get; set; }
        #endregion

        /// <summary>
        /// Стат (очки статистики)
        /// </summary>
        public Stat Stat { get; set; }
        /// <summary>
        /// Характеристики персонажа
        /// </summary>
        public PersonCharacteristic PersonCharacteristic { get; set; }
        /// <summary>
        /// Скиллы персонажа
        /// </summary>
        public List<PersonsSkill> PersonsSkills { get; set; }
    }
}
