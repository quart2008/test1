using System;
using System.IO.Compression;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Appeon.CoreService.AspNetCore;
using Appeon.PowerBuilder.AspNetCore;
using Appeon.CoreService.Data;
using Appeon.CoreService.Data.SqlServer;

namespace WebApplication2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(m =>
            {
                m.UseCoreIntegrated();
				m.UsePowerBuilderIntegrated();
            });

            services.AddGzipCompression(CompressionLevel.Fastest);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseResponseCompression();

            app.UseMvc();
			
			app.UseDataWindow();
        }
    }
}
