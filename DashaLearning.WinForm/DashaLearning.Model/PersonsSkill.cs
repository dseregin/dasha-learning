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
        /// Id
        /// </summary>
        public Guid Id { get; set; }

        #region Person
        /// <summary>
        /// Id Персонажа
        /// </summary>
        public Guid PersonId { get; set; }
        /// <summary>
        /// Предмет
        /// </summary>
        public Person Person { get; set; }
        #endregion

        #region Skill
        /// <summary>
        /// Id Скилла
        /// </summary>
        public Guid SkillId { get; set; }
        /// <summary>
        /// Скилл
        /// </summary>
        public Skill Skill { get; set; }
        #endregion

        /// <summary>
        /// Урон
        /// </summary>
        public int PowerValue { get; set; }
    }
}
