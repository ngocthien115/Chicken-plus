using ASM.Share.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachhangController : ControllerBase
    {
        private IKhachhangSvc _khachhangSvc;
        public KhachhangController(IKhachhangSvc khachhangSvc)
        {
            _khachhangSvc = khachhangSvc;
        }
        // GET: api/<KhachhangController>
        [HttpGet]
        public async Task<List<Khachhang>> Get()
        {
            var khs = _khachhangSvc.GetKhachhangAll();
            return khs;
        }

        // GET api/<KhachhangController>/5
        [HttpGet("{id}")]
        public Khachhang Get(int id)
        {
            var khs = _khachhangSvc.GetKhachhang(id);
            return khs;
        }

        // POST api/<KhachhangController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<KhachhangController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<KhachhangController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
