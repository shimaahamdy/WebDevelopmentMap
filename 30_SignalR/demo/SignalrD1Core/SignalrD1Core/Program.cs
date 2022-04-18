using SignalrD1Core.Hubs ;
using Microsoft.EntityFrameworkCore ;
using SignalrD1Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<chatContext>(n => n.UseSqlServer(builder.Configuration.GetConnectionString("iticon")));
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapHub<chatHub>("/chat");
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
