using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.Api.Helpers
{
    public static class HttpContextExtensions
    {
        /// <summary>
        /// Class phân trang
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="httpContext"></param>
        /// <param name="queryable"></param>
        /// <param name="recordPerPage"></param>
        /// <returns></returns>
        public static async Task InsertPaginationParameterInResponse<T>(this HttpContext httpContext,
            IQueryable<T> queryable, int recordPerPage)
        {
            double count = await queryable.CountAsync();
            double pagesQuantity = Math.Ceiling(count / recordPerPage);
            httpContext.Response.Headers.Add("soluongtrang", pagesQuantity.ToString());

        }
    }
}
