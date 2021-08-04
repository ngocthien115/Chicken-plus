using ASM.Share.Helpers;
using ASM.Share.Models.ViewModels;
//using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ASM.Share.Models
{
    public interface IDonhangChitietSvc
    {
        int AddDonhangChitietSvc(DonhangChitiet donhangChitiet);
        List<ViewDetails> getChiTiet(int id);
    }

    public class DonhangChitietSvc : IDonhangChitietSvc
    {
        protected DataContext _context;

        public DonhangChitietSvc(DataContext context)
        {
            _context = context;
        }
        public int AddDonhangChitietSvc(DonhangChitiet donhangChitiet)
        {
            int ret = 0;
            try
            {
                _context.Add(donhangChitiet);
                _context.SaveChanges();
                ret = donhangChitiet.ChitietID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
        public List<ViewDetails> getChiTiet(int id)
        {
            List<MonAn> monan = _context.MonAns.ToList();
            List<Donhang> donhang = _context.Donhangs.ToList();
            List<DonhangChitiet> donhangchtiet = _context.DonhangChitiets.ToList();

            List<ViewDetails> danhsach = (from ma in monan
                                          join ct in donhangchtiet on ma.MonAnID equals ct.MonAnID into table1
                                          from ct in table1.ToList()
                                          join dh in donhang on ct.DonhangID equals dh.DonhangID into table2
                                          from dh in table2.ToList()
                                          where ct.DonhangID == id
                                          select new ViewDetails
                                          {
                                              donhang = dh,
                                              monan = ma,
                                              donhangchitiet = ct
                                          }).ToList();
            return danhsach;
        }
    }    
}
