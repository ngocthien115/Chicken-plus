using ASM.Share.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.Api.Helpers
{
    public static class IQueryableExtensions
    {
        /// <summary>
        /// Class phân trang
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryable"></param>
        /// <param name="pagition"></param>
        /// <returns></returns>
        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable, Pagination pagition)
        {
            return queryable
                .Skip((pagition.Page - 1) * pagition.QuantityPerPage)
                .Take(pagition.QuantityPerPage);
        }
    }
}
