using Quiz.Common.Enums;
using Quiz.DAL.Entities.Base;
using System.Collections.Generic;

namespace Quiz.DAL.Entities
{
    /// <summary>
    /// Question entity
    /// </summary>
    public class Question : EntityBase<int>
    {
        /// <summary>
        /// Text of the question
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Question type
        /// </summary>
        public QuestionTypeEnum QuestionTypeEnum { get; set; }
        /// <summary>
        /// Answers (many answers to one question)
        /// </summary>
        public IEnumerable<Answer> Answers { get; set; }
    }

}
