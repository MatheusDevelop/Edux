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
    public class CadastrarController : ControllerBase
    {
        eduxContext contexto = new eduxContext();

   
        Cadastro cadastro = new Cadastro();



        [AllowAnonymous]
        [HttpPost]
        public IActionResult Cadastrar([FromBody] Usuario usuario)
        {
            var isSingned = cadastro.CadastrarUsuario(usuario);

            if (isSingned )
            {
                return Ok();
            }

            return Unauthorized();
        }
    }
}
