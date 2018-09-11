using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashaLearning.Model
{
    /// <summary>
    /// Класс Предмет чптичап
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
        /// Свойство получает/задает значение Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Название предмета
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Описание предмета
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Свойство получает/задает список Предметы персонажа
        /// </summary>
        public List<PersonsItem> PersonsItems { get; set; }
        #region Type
        /// <summary>
        /// Свойство получает/задает значение Id Типа
        /// </summary>
        public Guid TypeId { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Тип
        /// </summary>
        public Type Type { get; set; }
        #endregion
    }
}
