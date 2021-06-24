namespace TestJustForTest
{
    using System;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Pasquier.Rest;
    using TestJustForTest.Contracts;
    using TestJustForTest.Entities;
    using TestJustForTest.Repositories;

    public class Startup
    {
        private readonly IConfiguration _configuration;
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Startup"/>
        /// </summary>
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IPieceRepository, PieceRepository>();
            services.AddScoped<IMouvementParamRepository, MouvementParamRepository>();
            //services.AddUserPasquier();
            services.AddMvcPasquier();
            // services.AddSwaggerGenPasquier(_configuration.GetSection("OpenApi").Get<OpenApiPasquier>());
            services.AddDbContext<DatabaseContext>(
                options => options.UseSqlServer(_configuration.GetConnectionString("Messages")),
                ServiceLifetime.Transient
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            bool dev = env.IsDevelopment();
            app.UseExceptionPasquier(dev);
            //app.UseRequestLocalizationPasquier();
            app.UseCors(
                options => options
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
            );
            app.UseMvc();
            //app.UseSwaggerPasquier(dev);
        }
    }
}
