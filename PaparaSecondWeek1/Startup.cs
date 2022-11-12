using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using PaparaSecondWeek1.Middlewares;
using PaparaSecondWeek1.Models;
using PaparaSecondWeek1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaparaSecondWeek1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PaparaSecondWeek1", Version = "v1" });
            });

            ////Geçiçi. Servis her istenildiðinde yeni instance alýnýr
            services.AddTransient<IOwnerService, OwnerService>();
            //// Kapsamlý. yeni istel geldiðinde nesne oluþturulur
            //services.AddScoped<IOwnerService, OwnerService>();
            //// tek. ilk istek geldiðinde bir tane instance  oluþturur, Sorna gelen tüm istekleriçin ayný
            ////instance üzerinden devam ettirili
            //services.AddSingleton<IOwnerService, OwnerService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PaparaSecondWeek1 v1"));
            }


            app.UseHttpsRedirection();

            app.UseRouting();

         //  app.UseHeaderCheckMiddleware();

            app.UseAuthorization();

            app.UseExceptionMiddleware();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            //kendi yazdýðýmýz middleware
           // app.UseHeaderCheckMiddleware();
           // app.UseMiddleware<HeaderCheckMiddleware>(); // 2. farklý register etme yöntemi
        }
    }
}
