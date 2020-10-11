using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quiz.DAL.Entities;

namespace Quiz.DAL.Configurations
{
    /// <summary>
    /// Question entity configuration
    /// </summary>
    class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
