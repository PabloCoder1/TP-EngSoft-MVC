using DemoMVC.Models;
using DemoMVC.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoMVC.Controllers
{
    [Route("api/apicarro")]
    [ApiController]
    public class ApiCarroController : ControllerBase
    {
        protected readonly Repositorio repositorio = new Repositorio();
        // GET: api/<ApiCarroController>
        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return repositorio.GetAlunos();
        }

        // GET api/<ApiCarroController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ApiCarroController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ApiCarroController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApiCarroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
