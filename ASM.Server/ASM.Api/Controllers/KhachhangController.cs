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

        /// <summary>
        /// Lấy ra danh sách khách hàng
        /// </summary>
        /// <returns>Danh sách khách hàng</returns>
        //GET: api/<KhachhangController>
        [HttpGet]
        public IEnumerable<Khachhang> Get()
        {
            return _khachhangSvc.GetKhachhangAll();
        }
        
        /// <summary>
        /// Trả về thông tin của 1 khách hàng theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Thông tin của 1 khách hàng</returns>
        //GET api/<KhachhangController>/5
        [HttpGet("{id}")]
        public Khachhang Get(int id)
        {
            return _khachhangSvc.GetKhachhang(id);
        }

        /// <summary>
        /// Thêm mới 1 khách hàng
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///         POST api/khachhang
        ///         {
        ///             "FullName" : "Nguyen Van A",
        ///             "Ngaydat" : "10/8/2021",
        ///             "PhoneNumber" : "0123456789",
        ///             "EmailAddress" : "nguyena@gmail.com",
        ///             "Password" : "1",
        ///             "ConfirmPassword" : "1"
        ///         }
        /// </remarks>
        /// <param name="khachhang"></param>
        /// <returns>Thông tin khách hàng</returns>
        //GET api/<KhachhangController>/5
        // POST api/<KhachhangController>
        [AllowAnonymous]
        [HttpPost]
        public void Post([FromBody] Khachhang khachhang)
        {
            if (khachhang != null)
            {
                _khachhangSvc.AddKhachhang(khachhang);
            }
        }
        /// <summary>
        /// Chỉnh sửa thông tin của khách hàng
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT api/khachhang/1
        ///     {
        ///         "FullName" : "Nguyen Van A",
        ///         "Ngaydat" : "10/8/2021",
        ///         "PhoneNumber" : "0123456789",
        ///         "EmailAddress" : "nguyena@gmail.com",
        ///         "Password" : "1",
        ///         "ConfirmPassword" : "1"
        ///     }
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="khachhang"></param>
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
