using System.Collections.Generic;
using Quiz.DAL.Entities.Base;

namespace Quiz.DAL.Entities
{
    /// <summary>
    /// User entity
    /// </summary>
    public class User : EntityBase<int>
    {
        /// <summary>
        /// Clients ip
        /// </summary>
        public string IPAddress { get; set; }
        /// <summary>
        /// Answers reference (one user and many answers)
        /// </summary>
        public IEnumerable<Answer> Answers { get; set; }
    }
}
