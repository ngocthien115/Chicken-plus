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
        private readonly IDonhangChitietSvc _donhangchitietSvc;

        public DonhangController(IDonhangSvc donhangSvc, IDonhangChitietSvc donhangchitietSvc)
        {
            _donhangSvc = donhangSvc;
            _donhangchitietSvc = donhangchitietSvc;
        }

        /// <summary>
        /// Lấy danh sách toàn bộ các đơn hàng
        /// </summary>
        /// <returns>Danh sách đơn hàng</returns>
        /// <response code="200">List is show</response>
        /// <response code="201">List is show</response>
        /// <response code="401">Please provider token to send request</response>
        // GET: api/<DonhangController>
        [HttpGet]
        public IEnumerable<Donhang> Get()
        {
            return _donhangSvc.GetDonhangAll();
        }

        /// <summary>
        /// Lấy thông tin của 1 đơn hàng
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Thông tin 1 đơn hàng</returns>
        // GET api/<DonhangController>/5
        [HttpGet("{id}")]
        public IEnumerable<Donhang> Get(int id)
        {
            return _donhangSvc.GetDonhangbyKhachhang(id);
        }

        /// <summary>
        /// Thêm 1 đơn hàng mới
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///         POST api/donhang
        ///         {
        ///             "TrangthaiDonHang" : "moidat",
        ///             "KhachhangID" : "1",
        ///             "Tongtien" : 135000,
        ///             "Ngaydat" : "10/8/2021",
        ///             "Ghichu" : "",
        ///             "MonAnID" : "1",
        ///             "SoLuong" : "1",
        ///             "Thanhtien" : 17000,
        ///             "Ghichu" : ""
        ///         }
        /// </remarks>
        /// <param name="cart"></param>
        /// <returns>Thêm mới 1 đơn hàng</returns>
        /// <response code="200">A new donhang id created</response>
        /// <response code="201">A new donhang id created</response>
        /// <response code="401">Please provider token to send request</response>
        // POST api/<DonhangController>
        [HttpPost]
        public async Task<ActionResult<int>> Post(Cart cart)
        {
            try
            {
                var donhang = new Donhang()
                {
                    TrangthaiDonhang = TrangthaiDonhang.Moidat,
                    KhachhangID = cart.KhanghangId,
                    Tongtien = cart.Tongtien,
                    Ngaydat = DateTime.Now,
                    Ghichu = ""
                };
                int donhangid = _donhangSvc.AddDonhang(donhang);
                for (int i = 0; i < cart.ListViewCart.Count; i++)
                {
                    var dhct = new DonhangChitiet()
                    {
                        DonhangID = donhangid,
                        MonAnID = cart.ListViewCart[i].MonAn.MonAnID,
                        Soluong = cart.ListViewCart[i].Quantity,
                        Thanhtien = cart.ListViewCart[i].MonAn.Gia * cart.ListViewCart[i].Quantity,
                        Ghichu = ""
                    };
                    _donhangchitietSvc.AddDonhangChitietSvc(dhct);
                }
            }
            catch (Exception)
            {
                BadRequest(-1);
            }
            return Ok(1);
        }
    }
}
