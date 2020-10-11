using AutoMapper;
using Quiz.BLL.DTOs;
using Quiz.DAL.EF;
using System.Collections.Generic;

namespace Quiz.BLL.Services
{
    public class QuestionsService : ServiceBase
    {
        public QuestionsService(IMapper mapper, ApplicationContext context) : base(mapper, context)
        {
        }
        /// <summary>
        /// Get all questions
        /// </summary>
        /// <returns></returns>
        public IEnumerable<QuestionDto> GetQuestions()
        {
            return Mapper.ProjectTo<QuestionDto>(Context.Questions);
        }

        //TODO: CRUD for adding questions
    }
}
