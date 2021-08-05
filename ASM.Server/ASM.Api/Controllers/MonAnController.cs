using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASM.Share.Models;
using Microsoft.AspNetCore.Authorization;

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
        public MonAn Get(int id)
        {
            return _monanSvc.GetMonAn(id);
        }
    }
}
