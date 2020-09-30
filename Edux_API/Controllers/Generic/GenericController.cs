using System;
using System.Collections.Generic;

using Edux_API.Interfaces;
using Edux_API.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Edux_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T> : ControllerBase where T: class
    {


        private readonly IBase<T> repo;
        public GenericController(IBase<T> _repo)
        {

            repo = _repo;
        }
              
        
        /// <summary>
        /// Retorna uma lista mostrando todos os objetos da requisiçao
        /// </summary>
        /// <returns></returns>
        [HttpGet]        
        public List<T> Get()
        {
            return repo.BuscarTodos();
        }
        /// <summary>
        /// Retorna um unico objeto com o id especificado
        /// </summary>
        /// <param name="id">Id do objeto que voce quer procurar</param>
        /// <returns></returns>

        [HttpGet("{id}")]
        public T Get(Guid id)
        {
            return repo.BuscarPorId(id);
        }

        /// <summary>
        /// Adiciona o objeto do body da requisiçao ao banco
        /// </summary>
        /// <param name="obj">Objeto</param>
        [HttpPost]
        public void Post( T obj)
        {
            repo.Criar(obj);
        }

        /// <summary>
        /// Atualiza o objeto da requisiçao no banco de dados
        /// </summary>
        /// <param name="obj">Objeto</param>

        [HttpPut("{id}")]
        public void Put(T obj)
        {
            repo.Atualizar(obj);
        }

        /// <summary>
        /// Delete o objeto pelo id especificado
        /// </summary>
        /// <param name="id">Id do objeto</param>

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            repo.Deletar(id);
        }
    }
}
