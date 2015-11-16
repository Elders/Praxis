using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Dnx.Runtime;
using Microsoft.Framework.Configuration;
using Microsoft.Framework.DependencyInjection;
using Praxis.IdentityManager.Models;

namespace Praxis.IdentityManager
{
    public class Startup
    {
        private IConfigurationRoot configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient(x => new UserContext(configuration.Get<string>("Data:DefaultConnection:ConnectionString")));
            services.AddTransient<UserStore>();
            services.AddTransient<UserManager>();
        }

        public void Configure(IApplicationBuilder app, IApplicationEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                             .SetBasePath(env.ApplicationBasePath)
                             .AddJsonFile("config.json");
            configuration = builder.Build();
            // Add the platform handler to the request pipeline.
            app.UseIISPlatformHandler();
            app.UseMvc(m =>
            {
                m.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
