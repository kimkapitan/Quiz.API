using Quiz.Common.Enums;

namespace Quiz.BLL.DTOs
{
    /// <summary>
    /// DTO model for questions
    /// </summary>
    public class QuestionDto
    {
        /// <summary>
        /// Unique id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Text of question
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Type of question
        /// </summary>
        public QuestionTypeEnum QuestionTypeEnum { get; set; }
    }
}
