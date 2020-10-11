using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Quiz.DAL.EF;

namespace Quiz.DAL.Extensions
{
    /// <summary>
    /// Automigrate extension
    /// </summary>
    public static class MigrationExtension
    {
        public static IHost MigrateDatabase(this IHost webHost)
        {
            using var scope = webHost.Services.CreateScope();
            using var appContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
            appContext.Database.Migrate();
            return webHost;
        }
    }
}
