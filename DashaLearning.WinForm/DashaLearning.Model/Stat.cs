using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashaLearning.Model
{
    /// <summary>
    /// Класс Стат
    /// </summary>
    public class Stat
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Интеллект
        /// </summary>
        public int IntellectValue { get; set; }
        /// <summary>
        /// Ловкость
        /// </summary>
        public int AgilityValue { get; set; }
        /// <summary>
        /// Сила
        /// </summary>
        public int StrenghtValue { get; set; }

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
