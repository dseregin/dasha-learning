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
        /// Id
        /// </summary>
        public Guid Id { get; set; }
       
        #region Person
        /// <summary>
        /// Id Персонажа
        /// </summary>
        public Guid PersonId { get; set; }
        /// <summary>
        /// Персонаж
        /// </summary>
        public Person Person { get; set; }
        #endregion

        #region Item
        /// <summary>
        /// Id Предмета
        /// </summary>
        public Guid ItemId { get; set; }
        /// <summary>
        /// Предмет
        /// </summary>
        public Item Item { get; set; }
        #endregion

        /// <summary>
        /// Количество 
        /// </summary>
        public int Count { get; set; }

    }
}
