using System;

namespace DashaLearning.Model
{
    public class Person
    {
        public Guid Id { get; set; }
        #region User
        public Guid UserId { get; set; }
        public User User { get; set; }
        #endregion
        public string Name { get; set; }
        public bool Male { get; set; }
        #region Class
        public Guid ClassId { get; set; }
        public Class Class { get; set; }
        #endregion
        public Stat Stat { get; set; }
    }
}
