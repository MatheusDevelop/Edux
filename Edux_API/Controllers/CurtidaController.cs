﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edux_API.Domains;
using Edux_API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edux_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [Authorize(Roles = "Aluno,Professor,Admin")]
    public class CurtidaController :GenericController<Curtida>
    {
        public CurtidaController(IBase<Curtida> repos):base(repos)
        {

        }
    }
}
