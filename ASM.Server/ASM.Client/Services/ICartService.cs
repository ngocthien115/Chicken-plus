using ASM.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.Client.Services
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(List<MonAn> monans, int id);
    }
}
