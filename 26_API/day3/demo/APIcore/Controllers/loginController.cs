using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIcore.Models;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace APIcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        ITIContext db;
        public loginController(ITIContext db)
        {
            this.db = db;
        }

        [HttpPost]
        public IActionResult post(string email ,string password)
        {
            student st = db.Students.Where(n => n.email == email && n.password == password).FirstOrDefault();
            if(st != null)
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("my_sercret_key_123456"));    

               var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var data = new List<Claim>();
                data.Add(new Claim("name", st.name));

                var token = new JwtSecurityToken(
                
                claims:data,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

                return Ok( new JwtSecurityTokenHandler().WriteToken(token));

            }
            else
            {
                return Unauthorized();
            }

        }
    }
}
