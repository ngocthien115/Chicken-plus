﻿using ASM.Share.Helpers;
//using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ASM.Share.Models
{    
    public interface IDonhangSvc
    {
        List<Donhang> GetDonhangAll();

        List<Donhang> GetDonhangbyKhachhang(int khachhangId);

        Donhang GetDonhang(int id);

        int AddDonhang(Donhang donhang);

        int EditDonhang(int id, Donhang donhang);       
    }
    public class DonhangSvc : IDonhangSvc
    {
        protected DataContext _context;
       
        public DonhangSvc(DataContext context)
        {
            _context = context;            
        }

        public List<Donhang> GetDonhangAll()
        {
            List<Donhang> list = new List<Donhang>();
            // sử dụng kỹ thuật loading Eager // từ khóa Include
            list = _context.Donhangs.OrderByDescending(x => x.Ngaydat)
                .Include(x => x.Khachhang)
                .Include(x => x.DonhangChitiets)
                .ToList();
            return list;
        }

        public List<Donhang> GetDonhangbyKhachhang(int khachhangId)
        {
            List<Donhang> list = new List<Donhang>();
            // sử dụng kỹ thuật loading Eager // từ khóa Include
            list = _context.Donhangs.Where(x=>x.KhachhangID==khachhangId).OrderByDescending(x => x.Ngaydat)
                .Include(x => x.Khachhang)
                .Include(x => x.DonhangChitiets)
                .ToList();
            return list;
        }

        public Donhang GetDonhang(int id)
        {
            Donhang donhang = null;
            donhang = _context.Donhangs.Where(x=>x.DonhangID==id)
                .Include(x => x.Khachhang)
                .Include(x => x.DonhangChitiets).ThenInclude(y=>y.MonAn)
                .FirstOrDefault();
            //product = _context.Products.Where(e=>e.Id==id).FirstOrDefault(); //cách tổng quát
            return donhang;
        }

        public int AddDonhang(Donhang donhang)
        {
            int ret = 0;
            try
            {               
                _context.Add(donhang);
                _context.SaveChanges();
                ret = donhang.DonhangID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditDonhang(int id, Donhang donhang)
        {
            int ret = 0;
            try
            {
                _context.Update(donhang);
                _context.SaveChanges();
                ret = donhang.DonhangID;
            }
            catch(Exception ex)
            {
                ret = 0;
            }
            return ret;
        }
    }
    
}
