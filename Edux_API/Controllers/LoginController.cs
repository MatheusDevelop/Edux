using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edux_API.Contexts;
using Edux_API.Domains;
using Edux_API.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edux_API.Controllers
{
    //ESPECIAL

    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        eduxContext contexto = new eduxContext();
        Auth auth = new Auth();

        //JSON WebToken
        public string GerarJwt(Usuario user)
        {
            //Fazer o jwt
            return "....";
        }



        [AllowAnonymous]
        [HttpPost]
        
        public IActionResult Login([FromBody] Usuario usuario)
        {
            if(auth.AutenticarUsuario(usuario))
            {
                return Ok(new {token=GerarJwt(usuario)});
                
            }

            return Unauthorized();
            
        }
    }
}
