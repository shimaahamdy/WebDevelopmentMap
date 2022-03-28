using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApiCore.Context;
using WebApiCore.Models;

namespace WebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        ITIContext db;
        public LoginController(ITIContext db)
        {
            this.db = db;
        }
        [HttpPost]
        public IActionResult Login(Instructor s)
        {
            Instructor inst = db.Instructors.Where(S => S.Email == s.Email && S.Password == s.Password).FirstOrDefault();
            if (inst != null)
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("my_sercret_key_123456"));

                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var data = new List<Claim>();
                data.Add(new Claim("name", inst.Ins_Name));

                var token = new JwtSecurityToken(

                claims: data,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

                return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            }
            else return Unauthorized();
        }
    }
}
