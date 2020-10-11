using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Quiz.BLL.DTOs;
using System;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Quiz.API.Middlewares
{
    /// <summary>
    /// Middleware for handling exceptions.
    /// </summary>
    public class ErrorHandlingMiddleware
    {
        /// <summary>
        /// A function that can process an HTTP request.
        /// </summary>
        private readonly RequestDelegate _next;

        /// <summary>
        /// Initializes a new instance of the class. 
        /// </summary>
        /// <param name="next">A function that can process an HTTP request.</param>
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        /// Execute current chain requests.
        /// </summary>
        /// <param name="context">Http context.</param>
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var item = new ErrorDto();

            item.Status = (int)HttpStatusCode.BadRequest;
            item.Message = "Произошла ошибка!";

            var result = JsonConvert.SerializeObject(item);

            context.Response.ContentType = MediaTypeNames.Application.Json;
            context.Response.StatusCode = item.Status;

            await context.Response.WriteAsync(result);
        }
    }
}
