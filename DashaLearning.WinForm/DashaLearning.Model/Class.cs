using System;

namespace DashaLearning.Model
{
    /// <summary>
    /// Класс
    /// </summary>
    public class Class
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Название класса
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Другие характерстики
        /// </summary>
        public string SomeCharacteristics { get; set; }
    }
}