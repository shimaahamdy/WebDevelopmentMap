using Day8Demo_Mobile.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day8Demo_Mobile
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        //we request service of type IConfiguation to be used in startupClass, by injecting into ctor 
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        




        //dependecy Injection Container "Service Provider" => services enabled to be used by this app
        
        
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();  //enable this app to use MVC pattern
            
            
            
            services.AddDbContext<ProductDbContext>(op =>
                op.UseSqlServer(configuration.GetConnectionString("myConn"))   
            
            //op.UseSqlServer(configuration["ConnectionStrings:myConn"])    
            //op.UseSqlServer("Data Source=DESKTOP-VQ9K1EA\SQLEXPRESS;Initial Catalog=CUSTOMER.MDF;Integrated Security=True")
            );


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            if(env.IsEnvironment("myStaging"))
            {
                //connection string to Db Satging
                //bootstrap, css , ==> CDN
                //use custom error pages
            }


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapDefaultControllerRoute();

                endpoints.MapControllerRoute(
                    name: "myRoute",
                    pattern: "{controller=Product}/{action=Index}/{id?}"
                    );


                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!" + "\n" +
                //        configuration["myKey"] + "\n" + 
                //        configuration["ProjectDetails:Name"]);
                //});


            });
        }
    }
}
