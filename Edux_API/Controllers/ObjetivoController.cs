using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edux_API.Domains;
using Edux_API.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edux_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjetivoController : GenericController<Objetivo>
    {
        public ObjetivoController(IBase<Objetivo> repos):base(repos)
        {

        }
    }
}
