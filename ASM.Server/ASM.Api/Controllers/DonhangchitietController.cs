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

        /// <summary>
        /// Hiển thị thông tin chi tiết của 1 đơn hàng
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Thông tin của 1 đơn hàng</returns>
        // GET api/<DonhangController>/5
        [HttpGet("{id}")]
        public List<ViewDetails> Get(int id)
        {
            return _donhangChitietSvc.getChiTiet(id);
        }

        /// <summary>
        /// Tạo mới 1 chi tiết đơn hàng
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     
        ///      POST api/donhangchitiet
        ///      {
        ///          "DonhangID" : "1",
        ///          "MonAnID" : "1",
        ///          "SoLuong" : 3,
        ///          "Thanhtien" : 35000,
        ///          "Ghichu" : ""
        ///      }
        /// </remarks>
        /// <param name="donhangchitiet"></param>
        /// <response code="200">A newly is created</response>
        /// <response code="401">Please provider token to see</response>
        // POST api/<DonhangController>
        [HttpPost]
        public void Post([FromBody] DonhangChitiet donhangchitiet)
        {
            _donhangChitietSvc.AddDonhangChitietSvc(donhangchitiet);
        }
    }
}
