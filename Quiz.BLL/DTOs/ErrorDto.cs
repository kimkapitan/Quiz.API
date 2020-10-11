namespace Quiz.BLL.DTOs
{
    /// <summary>
    /// DTO model for sending errors (exceptions)
    /// </summary>
    public class ErrorDto
    {
        /// <summary>
        /// Status code
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// Exception message
        /// </summary>
        public string Message { get; set; }
    }
}
