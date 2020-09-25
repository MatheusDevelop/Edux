using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edux_API.Contexts;
using Edux_API.Domains;
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


        [AllowAnonymous]
        [HttpPost]

        public IActionResult Cadastrar([FromBody] Usuario usuario)
        {


            return Ok();

        }
    }
}
