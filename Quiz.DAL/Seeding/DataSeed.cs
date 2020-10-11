using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Quiz.DAL.EF;
using Quiz.DAL.Seeding.Seeds;

namespace Quiz.DAL.Seeding
{
    /// <summary>
    /// Seed data to DB
    /// </summary>
    public static class DataSeed
    {
        public static IHost DataSeeds(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetService<ApplicationContext>();

                context.Database.EnsureCreated();

                SeedQuestions.Seed(context);

            }
            return host;
        }
    }
}
