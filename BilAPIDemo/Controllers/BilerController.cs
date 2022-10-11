using BilAPIDemo.managers;
using BilAPIDemo.model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BilAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BilerController : ControllerBase
    {
        private readonly IBilerManager mgr = new BilerManager();


        // GET: api/<BilerController>
        [HttpGet]
        public IEnumerable<Bil> Get()
        {
            return mgr.GetAll();
        }

        // GET api/<BilerController>/5
        [HttpGet("{stelnummer}")]
        public Bil Get(string stelnummer)
        {
            return mgr.Get(stelnummer);
        }

        // POST api/<BilerController>
        [HttpPost]
        public void Post([FromBody] Bil value)
        {
            mgr.Create(value);
        }

        // PUT api/<BilerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BilerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
