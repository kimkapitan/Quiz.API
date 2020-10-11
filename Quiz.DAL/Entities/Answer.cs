using Quiz.DAL.Entities.Base;

namespace Quiz.DAL.Entities
{
    /// <summary>
    /// Answer entity
    /// </summary>
    public class Answer : EntityBase<int>
    {
        /// <summary>
        /// Question reference (one question and many answers)
        /// </summary>
        public Question Question { get; set; }
        /// <summary>
        /// Id of question
        /// </summary>
        public int QuestionId { get; set; }
        /// <summary>
        /// serialized answer as string
        /// </summary>
        public string AnswerValue { get; set; }
        /// <summary>
        /// User reference (one user and many answers)
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Id of user
        /// </summary>
        public int UserId { get; set; }
    }
}
