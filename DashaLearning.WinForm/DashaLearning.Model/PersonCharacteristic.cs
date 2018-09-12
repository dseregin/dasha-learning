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
        /// Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Жизнь
        /// </summary>
        public int MaxHp { get; set; }
        /// <summary>
        /// Мана
        /// </summary>
        public int MaxMana { get; set; }
        /// <summary>
        /// Опыт
        /// </summary>
        public int Experience { get; set; }
        /// <summary>
        /// Уровень
        /// </summary>
        public int Level { get; set; }

        #region person
        /// <summary>
        /// Id Персонажа
        /// </summary>
        public Guid PersonId { get; set; }
        /// <summary>
        /// Персонаж
        /// </summary>
        public Person Person { get; set; }
        #endregion
    }
}
