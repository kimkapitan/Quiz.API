using AutoMapper;
using Quiz.BLL.DTOs;
using Quiz.DAL.EF;
using System.Collections.Generic;
using System.Threading.Tasks;
using Quiz.DAL.Entities;

namespace Quiz.BLL.Services
{
    /// <summary>
    /// Consume answers and store them
    /// </summary>
    public class AnswersService : ServiceBase
    {
        private readonly UserService _userService;
        public AnswersService(IMapper mapper, ApplicationContext context, UserService userService) : base(mapper, context)
        {
            _userService = userService;
        }
        /// <summary>
        /// Add answers to DB
        /// </summary>
        /// <param name="answers"></param>
        /// <param name="ClientIP"></param>
        /// <returns></returns>
        public async Task AddAnswersAsync(IEnumerable<AnswerAddDto> answers, string ClientIP)
        {
            //get user by IP
            var user = await _userService.GetUserByIPAsync(ClientIP);

            foreach (var answer in answers)
            {
                Context.Answers.Add(new Answer
                {
                    QuestionId = answer.QuestionId,
                    AnswerValue = answer.Answer,
                    UserId = user.Id
                });
            }

            await Context.SaveChangesAsync();
        }

        //TODO: CRUD for get answers
    }
}
