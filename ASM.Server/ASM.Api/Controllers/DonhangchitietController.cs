using Microsoft.AspNetCore.Authorization;
using ASM.Share.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASM.Share.Models.ViewModels;

namespace ASM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DonhangchitietController : ControllerBase
    {
        private IDonhangChitietSvc _donhangChitietSvc;
        public DonhangchitietController(IDonhangChitietSvc donhangchitietSvc)
        {
            _donhangChitietSvc = donhangchitietSvc;
        }

        // GET api/<DonhangController>/5
        [HttpGet("{id}")]
        public List<ViewDetails> Get(int id)
        {
            return _donhangChitietSvc.getChiTiet(id);
        }

        // POST api/<DonhangController>
        [HttpPost]
        public void Post([FromBody] DonhangChitiet donhangchitiet)
        {
            _donhangChitietSvc.AddDonhangChitietSvc(donhangchitiet);
        }
    }
}
