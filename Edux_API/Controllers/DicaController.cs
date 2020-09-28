using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edux_API.Domains;
using Edux_API.Repositories.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Edux_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [Authorize(Roles = "Professor,Admin,Instituicao")]
    public class DicaController : ControllerBase
    {
        DicaRepository repo = new DicaRepository();

        /// <summary>
        /// Retorna uma lista mostrando todos os objetos da requisiçao
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Dica> Get()
        {
            return repo.LerDica();
        }
        /// <summary>
        /// Retorna um unico objeto com o id especificado
        /// </summary>
        /// <param name="id">Id do objeto que voce quer procurar</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Dica Get(Guid id)
        {
            return repo.SearchDicaForId(id);
        }

        /// <summary>
        /// Adiciona o objeto do body da requisiçao ao banco
        /// </summary>
        /// <param name="dica">Objeto</param>
        [HttpPost]
        public void Post(Dica dica)
        {
            repo.AdicionarDica(dica);
        }

        /// <summary>
        /// Atualiza o objeto da requisiçao no banco de dados
        /// </summary>
        /// <param name="dica">Objeto</param>
        [HttpPut]
        public void Put(Dica dica)
        {
            repo.AtualizarDica(dica);
        }

        /// <summary>
        /// Delete o objeto pelo id especificado
        /// </summary>
        /// <param name="id">Id do objeto</param>
        [HttpDelete]
        public void Delete(Guid id)
        {
            repo.RemoverDica(id);
        }

    }
}
