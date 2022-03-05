using ApiDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        private readonly ILogger<TestController> _logger;
        private readonly TodoContext _db;
        

        public TestController(ILogger<TestController> logger,TodoContext db)
        {
            _logger = logger;
            _db = db;
        }
        // GET: api/<TestController>
        [HttpGet]
        public IEnumerable<TodoItem> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1,3).Select(index =>  _db.TodoItems.Single(x=>x.Id==index))
            .ToArray();
        }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
