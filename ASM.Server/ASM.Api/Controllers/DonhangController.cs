using ASM.Share.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASM.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DonhangController : ControllerBase
    {
        private IDonhangSvc _donhangSvc;
        public DonhangController(IDonhangSvc donhangSvc)
        {
            _donhangSvc = donhangSvc;
        }
        // GET: api/<DonhangController>
        [HttpGet]
        public IEnumerable<Donhang> Get()
        {
            return _donhangSvc.GetDonhangAll();
        }

        // GET api/<DonhangController>/5
        [HttpGet("{id}")]
        public Donhang Get(int id)
        {
            return _donhangSvc.GetDonhang(id);
        }

        // POST api/<DonhangController>
        [HttpPost]
        public void Post([FromBody] Donhang donhang)
        {
            if (donhang != null)
            {
                _donhangSvc.AddDonhang(donhang);
            }
        }
    }
}
