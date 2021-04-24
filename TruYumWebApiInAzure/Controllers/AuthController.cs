using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruYumWebApiInAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private string CreateJwtToken()
        {
            var SecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("secretkeyarespecial"));
            var Credentials = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken
            (
                issuer: "mySystem",
                audience: "myUsers",
                expires: DateTime.Now.AddMinutes(10),
                signingCredentials: Credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        [HttpGet]
        public IActionResult Get()
        {
            string s = CreateJwtToken();
            return Ok(s);
        }
    }
}
