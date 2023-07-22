﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Modal
{
    public class NguoiThan
    {

        public Guid Id { get; set; }    
        public string Name { get; set; }    
        public bool GioiTinh { get; set; }
        
        public string DiaChi { get; set; }
        [Phone]
        [StringLength(10, ErrorMessage = "nhap 10 ky tu")]
        public string SDT { get; set; }
        [Phone]
        public int CCCD { get; set; }
        public Guid IdKhachHang { get; set; }

        public virtual KhachHang KhachHangs { get; set;}
    }
}
