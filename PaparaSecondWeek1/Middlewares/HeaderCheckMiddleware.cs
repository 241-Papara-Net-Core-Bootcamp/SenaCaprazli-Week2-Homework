using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaparaSecondWeek1.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class HeaderCheckMiddleware
    {
        private readonly RequestDelegate _next;

        public HeaderCheckMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var ClientKey = httpContext.Request.Headers.Keys.Contains("Client-Key");
            if (!ClientKey)
            {
                httpContext.Response.StatusCode = 400;
                await httpContext.Response.WriteAsync("Client-Key bulunamadı");
                return;
            }
          
            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class HeaderCheckMiddlewareExtensions
    {
        public static IApplicationBuilder UseHeaderCheckMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HeaderCheckMiddleware>();
        }
    }
}
