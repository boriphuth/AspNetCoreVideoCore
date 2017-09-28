using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using AspNetCoreVideoCore.Services;
using Microsoft.AspNetCore.Routing;
using AspNetCoreVideoCore.Data;
using Microsoft.EntityFrameworkCore;
using AspNetCoreVideoCore.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AspNetCoreVideoCore
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true);

            if (env.IsDevelopment())
                builder.AddUserSecrets<Startup>();

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var conn = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<VideoDbContext>(options =>
                options.UseSqlServer(conn));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<VideoDbContext>();

            services.AddMvc();
            services.AddSingleton(provider => Configuration);
            services.AddSingleton<IMessageService, ConfigurationMessageService>();
            services.AddSingleton<IVideoData, SqlVideoData>();
        }

        public void Configure(IApplicationBuilder app,
        IHostingEnvironment env, ILoggerFactory loggerFactory, IMessageService msg)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseFileServer();
            app.UseIdentity();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(msg.GetMessage());
            });
        }

    }
}
