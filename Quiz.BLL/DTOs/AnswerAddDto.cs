namespace Quiz.BLL.DTOs
{
    /// <summary>
    /// DTO model for Add new answers to store
    /// </summary>
    public class AnswerAddDto
    {
        /// <summary>
        /// Question unique id
        /// </summary>
        public int QuestionId { get; set; }
        /// <summary>
        /// Store all type of answers as serialized string
        /// </summary>
        public string Answer { get; set; }
    }
}
