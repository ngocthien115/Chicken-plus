using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Share.Models.ViewModels
{
    public class Pagination
    {
        // Model phân trang
        public int Page { get; set; } = 1;
        public int QuantityPerPage { get; set; } = 8;
    }
}
