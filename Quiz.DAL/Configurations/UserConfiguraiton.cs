using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quiz.DAL.Entities;

namespace Quiz.DAL.Configurations
{
    /// <summary>
    /// User entity configuration
    /// </summary>
    class UserConfiguraiton : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
