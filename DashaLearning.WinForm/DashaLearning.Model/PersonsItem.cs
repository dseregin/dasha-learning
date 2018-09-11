using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashaLearning.Model
{
    /// <summary>
    /// Класс Предметы персонажа
    /// </summary>
    public class PersonsItem
    {
        /// <summary>
        /// Свойство получает/задает значение Id
        /// </summary>
        public Guid Id { get; set; }
        #region Person
        /// <summary>
        /// Свойство получает/задает значение Id Персонажа
        /// </summary>
        public Guid PersonId { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Предмет
        /// </summary>
        public Person Person { get; set; }
        #endregion
        #region Item
        /// <summary>
        /// Свойство получает/задает значение Id Предмета
        /// </summary>
        public Guid ItemId { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Предмет
        /// </summary>
        public Item Item { get; set; }
        #endregion
        /// <summary>
        /// Свойство получает/задает значение Количество 
        /// </summary>
        public int Count { get; set; }

    }
}
