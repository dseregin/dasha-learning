using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashaLearning.Model
{
    /// <summary>
    /// Класс Умение
    /// </summary>
    public class Skill
    {
        /// <summary>
        /// Конструктор класса Скилл
        /// </summary>
        public Skill()
        {
            PersonsSkills = new List<PersonsSkill>();
        }
        /// <summary>
        /// Свойство получает/задает значение Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Название скилла
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Описание скилла
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Свойство получает/задает список Скиллы персонажа
        /// </summary>
        public List<PersonsSkill> PersonsSkills { get; set; }
    }
}
