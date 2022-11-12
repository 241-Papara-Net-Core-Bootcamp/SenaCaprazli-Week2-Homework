using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using PaparaSecondWeek1.Models;

namespace PaparaSecondWeek1.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);

            }
            catch (Exception ex)
            {

                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                await httpContext.Response.WriteAsync(new ErrorModel()
                {
                    StatusCode = httpContext.Response.StatusCode,
                    Message = ex.Message
                }.ToString());
            }

           
        }

        //private static async Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
        //{
        //    httpContext.Response.ContentType = "application/json";
        //    httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        //    await httpContext.Response.WriteAsync(new ErrorModel()
        //    {
        //        StatusCode = httpContext.Response.StatusCode,
        //        Message = ex.Message
        //    }.ToString());
        //}
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
