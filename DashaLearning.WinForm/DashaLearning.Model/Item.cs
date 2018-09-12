using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashaLearning.Model
{
    /// <summary>
    /// Класс Предмет
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Конструктор класса Предмет
        /// </summary>
        public Item()
        {
            PersonsItems = new List<PersonsItem>();
        }
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Название предмета
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание предмета
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Предметы персонажа
        /// </summary>
        public List<PersonsItem> PersonsItems { get; set; }
        #region Type
        /// <summary>
        /// Id Типа
        /// </summary>
        public Guid TypeId { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public Type Type { get; set; }
        #endregion
    }
}
