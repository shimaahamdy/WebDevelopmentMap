using Day8_Demo_42.Model;
using Day8_Demo_42.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Day8_Demo_42
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        //DI Container -- Service Provider
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();

            services.AddDbContext<ProductDbContext>(op =>
                op.UseSqlServer(Configuration.GetConnectionString("myConn"))

            //op.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=Product_CoreDb_42;Integrated Security=True")
            //op.UseSqlServer(Configuration["ConnectionStrings:myConn"])
            );


            services.AddDbContext<CUSTOMERMDFContext>(op =>
                op.UseSqlServer(Configuration.GetConnectionString("myConn2"))
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //local styles
                //connection string test db
            }

            if (env.IsProduction())
            {
                app.UseDeveloperExceptionPage();
                //CDN styles
                //connection string Final db
            }

            if (env.IsEnvironment("StagingAfterFirstChange"))
            {

            }


            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "myOwnRoute",
                    pattern: "{controller=Product}/{action=Index}/{id?}",
                    defaults: "{controller=Product}/{action=Index}/{id?}"
                    );

                //endpoints.MapDefaultControllerRoute();

                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!" +
                //        "\n" + Configuration["myKey"]
                //        );
                //});
            });
        }
    }
}
