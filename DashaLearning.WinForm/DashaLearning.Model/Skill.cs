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
        /// Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Название скилла
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание скилла
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Скиллы персонажа
        /// </summary>
        public List<PersonsSkill> PersonsSkills { get; set; }
    }
}
