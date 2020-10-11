using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quiz.DAL.Entities;

namespace Quiz.DAL.Configurations
{
    /// <summary>
    /// Answer entity configuration
    /// </summary>
    class AnswerConfiguraiton : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Question).WithMany(x => x.Answers).HasForeignKey(x => x.QuestionId);
            builder.HasOne(x => x.User).WithMany(x => x.Answers).HasForeignKey(x => x.UserId);
        }
    }
}
