using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edux_API.Domains;
using Edux_API.Interfaces;
using Edux_API.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edux_API.Controllers
{
    [Route("api/[controller]")]


    [ApiController]
    public class TurmaController : GenericController<Turma>
    {
        TurmaRepositoru rep = new TurmaRepositoru();
        public TurmaController(IBase<Turma> repos) : base(repos)
        {

        }

        [HttpGet]
        public override List<Turma> Get()
        {
            var res = rep.BuscarTodos();
            return res;
        }
        
    }
}
