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
        // GET: api/<DonhangController>
        [HttpGet]
        public IEnumerable<Donhang> Get()
        {
            return _donhangSvc.GetDonhangAll();
        }

        // GET api/<DonhangController>/5
        [HttpGet("{id}")]
        public IEnumerable<Donhang> Get(int id)
        {
            return _donhangSvc.GetDonhangbyKhachhang(id);
        }

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
