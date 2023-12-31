﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Modal
{
    public class BaoDuong
    {
        
        public Guid Id { get; set; }
        public DateTime NgayDangKiem { get; set; }
        public DateTime NgayHetHan { get; set; }
        public decimal ChiPhi { get; set; }
        public int SoCongToBaoDuong { get; set; }
        public int TrangThai { get; set; }
        public string ChiTiet { get; set; }
        public Guid IdXe { get; set; }
        public virtual Xe Xe { get; set; }
    }
}
