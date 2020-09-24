using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edux_API.Domains;
using Edux_API.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Edux_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : GenericController<Curso>
    {

        
    }
}
