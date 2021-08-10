using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASM.Share.Models;
using Microsoft.AspNetCore.Authorization;
using ASM.Share.Models.ViewModels;
using ASM.Api.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonAnController : ControllerBase
    {
        private readonly DataContext _context;
        private IMonAnSvc _monanSvc;
        public MonAnController(IMonAnSvc svc, DataContext data)
        {
            _context = data;
            _monanSvc = svc;
        }
        /// <summary>
        /// Danh sách các món ăn có phân có phân trang
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET api/monan
        ///         Params  - page:1
        ///                 - quantityperpage:5
        ///             
        /// </remarks>
        /// <param name="pagination"></param>
        /// <returns>Danh sách món ăn trong trang</returns>
        /// <response code="200">Return a list monan</response>
        // GET: api/<MonAnController>
        [HttpGet]
        public async Task<List<MonAn>> Get([FromQuery]Pagination pagination)
        {
            // Phân trang
            var queryable = _context.MonAns.AsQueryable();
            await HttpContext.InsertPaginationParameterInResponse(queryable, pagination.QuantityPerPage);
            return await queryable.Paginate(pagination).ToListAsync();
            //// Không phân trang
            //List<MonAn> monans = new List<MonAn>();
            //monans = _monanSvc.GetMonAnAll();
            //return monans;

        }

        /// <summary>
        /// Thông tin của 1 món ăn theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Thông tin món ăn theo id</returns>
        // GET api/<MonAnController>/5
        [HttpGet("{id}")]
        public MonAn Get(int id)
        {
            return _monanSvc.GetMonAn(id);
        }

        //[Route("search/{phanloai}")]
        //public async Task<IEnumerable<MonAn>> Get(Phanloai phanloai)
        //{
        //    return await _monanSvc.Phanloai(phanloai);
        //}
    }
}
