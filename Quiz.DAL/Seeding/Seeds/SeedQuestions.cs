using Microsoft.EntityFrameworkCore.Internal;
using Quiz.Common.Enums;
using Quiz.DAL.EF;
using Quiz.DAL.Entities;
using Quiz.DAL.Extensions;
using System.Linq;

namespace Quiz.DAL.Seeding.Seeds
{
    /// <summary>
    /// Seed default questions
    ///
    /// Maybe better was to write SQL script in migration, but I decided to make it like this
    /// 
    /// </summary>
    static class SeedQuestions
    {
        public static void Seed(ApplicationContext context)
        {

            context.AddQuestion(new Question
            {
                Text = "Введите имя",
                QuestionTypeEnum = QuestionTypeEnum.QuestionString
            })
                .AddQuestion(new Question
                {
                    Text = "Введите возраст",
                    QuestionTypeEnum = QuestionTypeEnum.QuestionInt
                })
                .AddQuestion(new Question
                {
                    Text = "Введите пол",
                    QuestionTypeEnum = QuestionTypeEnum.QuestionSexEnum
                })
                .AddQuestion(new Question
                {
                    Text = "Введите дату рождения",
                    QuestionTypeEnum = QuestionTypeEnum.QuestionDateTime
                })
                .AddQuestion(new Question
                {
                    Text = "Введите семейное положение",
                    QuestionTypeEnum = QuestionTypeEnum.QuestionMaritalStatusEnum
                })
                .AddQuestion(new Question
                {
                    Text = "Любите ли вы программировать",
                    QuestionTypeEnum = QuestionTypeEnum.QuestionBool
                });
            context.SaveChanges();
        }

        private static ApplicationContext AddQuestion(this ApplicationContext context, Question question)
        {
            if (!context.Questions.NotDeleted().Any(x => x.Text.Equals(question.Text) && x.QuestionTypeEnum == question.QuestionTypeEnum))
            {
                context.Questions.Add(question);
            }

            return context;
        }
    }
}
