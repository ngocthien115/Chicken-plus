using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASM.Share.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonAnController : ControllerBase
    {
        private IMonAnSvc _monanSvc;
        public MonAnController(IMonAnSvc svc)
        {
            _monanSvc = svc;
        }
        // GET: api/<MonAnController>
        [HttpGet]
        public List<MonAn> Get()
        {
            return _monanSvc.GetMonAnAll();
        }

        // GET api/<MonAnController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MonAnController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MonAnController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MonAnController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
