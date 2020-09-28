using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Edux_API.Contexts;
using Edux_API.Domains;
using Edux_API.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Edux_API.Controllers
{
    //ESPECIAL

    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        
        Auth auth = new Auth();

        private IConfiguration _config;

        public LoginController(IConfiguration config)
        {
            _config = config;
        }

        //JSON WebToken
        private string GerarJwt(Usuario userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Email, userInfo.Email),
                new Claim(JwtRegisteredClaimNames.NameId, userInfo.Nome),
                new Claim(ClaimTypes.Role, userInfo.IdPerfilNavigation.Permissao),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            var token = new JwtSecurityToken
                (
                    _config["Jwt:Issuer"],
                    _config["Jwt:Issuer"],
                    claims,
                    expires: DateTime.Now.AddMinutes(90),
                    signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [AllowAnonymous]
        [HttpPost]
        
        public IActionResult Login([FromBody] Usuario usuario)
        {
            var user = auth.AutenticarUsuario(usuario);
            if (user != null)
            {                
                return Ok(new {token=GerarJwt(user)});                
            }

            return Unauthorized();
            
        }
    }
}
