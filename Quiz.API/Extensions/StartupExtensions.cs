using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Quiz.API.Middlewares;
using Quiz.BLL.Profiles;
using Quiz.BLL.Services;
using Quiz.DAL.EF;

namespace Quiz.API.Extensions
{
    public static class StartupExtensions
    {
        /// <summary>
        /// add DBContext and SQLServer
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="connectionString"></param>
        public static void AddDBContext(this IServiceCollection services, IConfiguration configuration, string connectionString)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString(connectionString)));
        }

        /// <summary>
        /// Add swagger for API review
        /// </summary>
        /// <param name="services"></param>
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen();
        }
        /// <summary>
        /// Add Cross-origin resource sharing 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="corsPolicyName"></param>
        public static void AddCors(this IServiceCollection services, string corsPolicyName)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(corsPolicyName,
                    builder => builder
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowAnyOrigin()
                );
            });
        }
        /// <summary>
        /// Add BLL services
        /// </summary>
        /// <param name="services"></param>
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<QuestionsService>();
            services.AddScoped<AnswersService>();
            services.AddScoped<UserService>();
        }
        /// <summary>
        /// Configure automapper
        /// Add profiles here
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureAutoMapperProfiles(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
                mc.AllowNullCollections = true;
            });
            var mapper = mappingConfig.CreateMapper();

            services.AddSingleton(mapper);
        }
        /// <summary>
        /// add middlewares
        /// </summary>
        /// <param name="app"></param>
        public static void UseMiddlewares(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlingMiddleware>();
        }
        /// <summary>
        /// use swagger UI
        /// </summary>
        /// <param name="app"></param>
        public static void UseSwaggerUI(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.DisplayRequestDuration();
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "QuizTest.API");
                c.RoutePrefix = "swagger";
            });
        }

    }
}
