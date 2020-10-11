using Microsoft.AspNetCore.Mvc;
using Quiz.BLL.DTOs;
using Quiz.BLL.Services;
using System.Collections.Generic;

namespace Quiz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly QuestionsService _service;
        public QuestionsController(QuestionsService service)
        {
            _service = service;
        }
        // GET api/Questions 
        /// <summary>
        /// Get all questions
        /// </summary>
        /// <returns>List of questions</returns>
        /// <remarks>
        /// Collection of possible errors:\
        /// <b>Status code = 400</b> Произошла ошибка!\
        /// </remarks>
        [HttpGet]
        public IEnumerable<QuestionDto> GetQuestions()
        {
            return _service.GetQuestions();
        }

        //TODO: CRUD for adding questions
    }
}
