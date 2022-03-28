using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebApiCore.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//help page 3rd party creator to design and create help page (swashbuck, nswag)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add cores enable
string coresTxt = "";
//cors service
builder.Services.AddCors(options =>
{
    options.AddPolicy(coresTxt,
    builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});
//add ITIContext service with that options if any one ask about it
builder.Services.AddDbContext<ITIContext>(O => O.UseSqlServer(builder.Configuration.GetConnectionString("ITIConection")));


//JWTVaildate
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateLifetime = true, 
        ValidateAudience = false,
        ValidateIssuer = false,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("my_sercret_key_123456"))

    };
});










//----------------------------------------------------------------------
var app = builder.Build();
// Configure the HTTP request pipeline.
//use services
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//use cors
app.UseCors(coresTxt);
//use token --> authantication
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
