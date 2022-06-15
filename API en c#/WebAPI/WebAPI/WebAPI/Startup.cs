using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using WebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using FluentValidation;





namespace WebAPI
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
           
        
            services.AddMvc();
            services.AddMvcCore();
            
    
            //cargo contexto 1
            services.AddDbContext<WebAPIContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("WebAPIContext"), //nombre de la clave valor que contiene la cadena de conexion sql en appsettings.json
                    b => b.MigrationsAssembly(typeof(WebAPIContext).Assembly.FullName)));



            #region Swagger
            services.AddSwaggerGen(c =>
            {
              
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
            });
            #endregion
            services.AddScoped<IWebAPIContext>(provider => provider.GetService<WebAPIContext>());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddControllers();

        


            //para poder acceder desde cualquier origen / servidor. (de stackoverflow)
            services.AddCors(options =>
            {
                options.AddPolicy("permitir", builder =>
                {
                    builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
                });
            });

           
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("permitir"); //para poder acceder desde cualquier origen(agregarlo en el controlador.)

            app.UseAuthorization();

             #region Swagger
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI");
            });
            #endregion

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            

        }
    }
}
