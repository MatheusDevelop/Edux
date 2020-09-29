
using Edux_API.Domains;
using Edux_API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Edux_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    [Authorize(Roles = "Instituicao,Admin")]


    public class AlunoTurmaController : GenericController<AlunoTurma>
    {
        
    }
}
