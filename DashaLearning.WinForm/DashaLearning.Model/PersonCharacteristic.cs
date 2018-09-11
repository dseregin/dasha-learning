using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashaLearning.Model
{
    /// <summary>
    /// Класс Характеристики персонажа
    /// </summary>
    public class PersonCharacteristic
    {
        /// <summary>
        /// Свойство получает/задает значение Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Жизнь
        /// </summary>
        public int MaxHp { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Мана
        /// </summary>
        public int MaxMana { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Опыт
        /// </summary>
        public int Experience { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Уровень
        /// </summary>
        public int Level { get; set; }
        #region person
        /// <summary>
        /// Свойство получает/задает значение Id Персонажа
        /// </summary>
        public Guid PersonId { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Персонажа
        /// </summary>
        public Person Person { get; set; }
        #endregion
    }
}
