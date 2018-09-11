using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashaLearning.Model
{
    /// <summary>
    /// Класс Умение Пользователя
    /// </summary>
    public class PersonsSkill
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
        #region Skill
        /// <summary>
        /// Свойство получает/задает значение Id Скилла
        /// </summary>
        public Guid SkillId { get; set; }
        /// <summary>
        /// Свойство получает/задает значение Скилл
        /// </summary>
        public Skill Skill { get; set; }
        #endregion
        /// <summary>
        /// Свойство получает/задает значение Урон
        /// </summary>
        public int PowerValue { get; set; }
    }
}
