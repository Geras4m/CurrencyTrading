using OXR.Trading.Common.DI;
using OXR.Trading.Data.Entities;
using OXR.Trading.Core.DI;
using OXR.Trading.Data.DI;
using OXR.Trading.Common.Exceptions.Handling;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using AutoMapper;
using Microsoft.OpenApi.Models;
using OXR.Trading.WebApi.Models.Config;
using Microsoft.AspNetCore.Mvc.Formatters;
using OXR.Trading.ApiFramework.DI;

namespace OXR.Trading.WebApi
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

            services.AddMvcCore(options =>
            {
                options.RespectBrowserAcceptHeader = true;
                options.OutputFormatters.RemoveType<StringOutputFormatter>();
                options.OutputFormatters.RemoveType<HttpNoContentOutputFormatter>();
                options.Filters.Add(new GlobalExceptionFilter());
            }).AddApiExplorer();
            


            services.AddDbContext<TradingDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("MainConnection")
                )
            );

            services.Configure<AppConfig>(Configuration.GetSection("AppConfig"));

            services.AddMapperServices();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddApiFrameworkServices();
            services.AddBusinessLogicServices();
            services.AddRepositoryServices();

            services.AddSwaggerGen(cfg =>
            {
                cfg.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "DA Trading API",
                    Version = "v1"
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(cfg =>
            {
                cfg.SwaggerEndpoint("/swagger/v1/swagger.json", "DA Trading API");
                cfg.RoutePrefix = string.Empty;
            });
        }
    }
}
