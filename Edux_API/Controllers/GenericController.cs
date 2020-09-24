using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edux_API.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Edux_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T> : ControllerBase where T: class
    {

        BaseGeneric<T> repo = new BaseGeneric<T>();

        // GET: api/<GenericController>
        [HttpGet]
        public string Get()
        {
            return "Ta funcionando buceta";
        }

        // GET api/<GenericController>/5
        [HttpGet("{id}")]
        public T Get(Guid id)
        {
            return repo.BuscarPorId(id);
        }

        // POST api/<GenericController>
        [HttpPost]
        public void Post([FromBody] T obj)
        {
            repo.Criar(obj);
        }

        // PUT api/<GenericController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] T obj)
        {
            repo.Atualizar(obj);
        }

        // DELETE api/<GenericController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            repo.Deletar(id);
        }
    }
}
