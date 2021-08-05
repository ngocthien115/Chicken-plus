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
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class KhachhangController : ControllerBase
    {
        private IKhachhangSvc _khachhangSvc;
        public KhachhangController(IKhachhangSvc khachhangSvc)
        {
            _khachhangSvc = khachhangSvc;
        }

        // GET: api/<KhachhangController>
        //[HttpGet]
        //public IEnumerable<Khachhang> Get()
        //{
        //    return _khachhangSvc.GetKhachhangAll();
        //}

        // GET api/<KhachhangController>/5
        
        [HttpGet("{id}")]
        public Khachhang Get(int id)
        {
            return _khachhangSvc.GetKhachhang(id);
        }

        [AllowAnonymous]
        // POST api/<KhachhangController>
        [HttpPost]
        public void Post([FromBody] Khachhang khachhang)
        {
            if (khachhang != null)
            {
                _khachhangSvc.AddKhachhang(khachhang);
            }
        }

        // PUT api/<KhachhangController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Khachhang khachhang)
        {
            if (id != 0 && khachhang != null)
            {
                _khachhangSvc.EditKhachhang(id, khachhang);
            }
        }
    }
}
