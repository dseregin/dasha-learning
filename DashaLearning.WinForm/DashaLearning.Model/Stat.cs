﻿using System;
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
        /// Свойство получает/задает значение Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Интеллект
        /// </summary>
        public int IntellectValue { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Ловкость
        /// </summary>
        public int AgilityValue { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Сила
        /// </summary>
        public int StrenghtValue { get; set; }

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
