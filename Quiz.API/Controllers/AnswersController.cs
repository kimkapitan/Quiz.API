using Microsoft.AspNetCore.Mvc;
using Quiz.BLL.DTOs;
using Quiz.BLL.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Quiz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : ControllerBase
    {
        private readonly AnswersService _service;
        public AnswersController(AnswersService service)
        {
            _service = service;
        }
        // POST api/Answers 
        /// <summary>
        /// Add answers by user
        /// </summary>
        /// <param name="answers">list of answers</param>
        /// <returns></returns>
        /// <remarks>
        /// Collection of possible errors:\
        /// <b>Status code = 400</b> Произошла ошибка!\
        /// </remarks>
        [HttpPost]
        public async Task AddAnswers(IEnumerable<AnswerAddDto> answers)
        {
            await _service.AddAnswersAsync(answers, Request.HttpContext.Connection.RemoteIpAddress.ToString());
        }

        //TODO: CRUD for get answers
    }
}
