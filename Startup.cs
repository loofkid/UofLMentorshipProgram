using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UofLMentorshipProgram.Data;
using MySqlConnector;
using UofLMentorshipProgram.Models.Options;

namespace UofLMentorshipProgram
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
            services.AddDbContext<MentorshipContext>((sp, options) => {
                var csb = new MySqlConnectionStringBuilder(Configuration.GetConnectionString("Mentorship"));
                csb.Add("Pwd", Configuration.GetSection("DB:Mentorship").Get<DBOptions>().Password);
                options.UseMySql(csb.ConnectionString, ServerVersion.AutoDetect(csb.ConnectionString));
            });
            services.AddDbContext<MentorshipContext>((sp, options) => {
                var csb = new MySqlConnectionStringBuilder(Configuration.GetConnectionString("WordPress"));
                csb.Add("Pwd", Configuration.GetSection("DB:Mentorship").Get<DBOptions>().Password);
                options.UseMySql(csb.ConnectionString, ServerVersion.AutoDetect(csb.ConnectionString));
            });
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
