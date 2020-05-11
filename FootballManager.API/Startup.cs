using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballManager.Bl.Abstract;
using FootballManager.Bl.Impl;
using FootballManager.DAL.Abstract;
using FootballManager.DAL.Impl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FootballManager.API
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
           
            services.AddDbContext<FootballManagerContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => { b.MigrationsAssembly("FootballManager"); b.EnableRetryOnFailure(); }));

            services.AddTransient<IRepositoryPlayer, PlayerRepository>();
            services.AddTransient<IRepositoryCommand, CommandRepository>();
            services.AddTransient<IRepositoryMatch, MatchRepository>();
            services.AddTransient<IRepositoryChampionship, ChampionshipRepository>();
            services.AddTransient<IRepositoryChampionshipCommand, ChampionshipCommandRepository>();


            services.AddTransient<IPlayerService, PlayerService>();
            services.AddTransient<ICommandService, CommandService>();
            services.AddTransient<IMatchService, MatchService>();
            services.AddTransient<IChampionshipService, ChampionshipService>();
            services.AddTransient<IChampionshipCommandService, ChampionshipCommandService>();
            //services.AddTransient<IValidService, ValidService>();
            services.AddTransient<IFMService, FMService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
