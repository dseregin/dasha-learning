using System;

namespace DashaLearning.Model
{
    /// <summary>
    /// Класс Класс
    /// </summary>
    public class Class
    {
        /// <summary>
        /// Свойство получает/задает значение Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Название класса
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Другие характерстики
        /// </summary>
        public string SomeCharacteristics { get; set; }
    }
}