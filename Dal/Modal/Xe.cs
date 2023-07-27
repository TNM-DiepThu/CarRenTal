using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Modal
{
    public class Xe
    {
       
        public Guid ID { get; set; }    
        public string BienSo {get ; set; }
        public string SoKhung { get; set; }
        public string SoMay { get; set; }
        public decimal DonGia { get; set; }
        public int SoCongTo { get; set; }
        public int TrangThai { get; set; }
        public Guid IdLoaiXe { get; set; }
        public virtual LoaiXe LoaiXe { get; set; }
        public Guid IdMauSac { get; set; }
        public virtual MauSac MauSac { get; set; }
        public ICollection<DangKiem> DangKiem { get; set; }
        public ICollection<XeBaoHiem> xeBaoHiems { get; set; }
        public ICollection <BaoDuong> baoDuongs { get; set; }
        public ICollection <HoaDonChiTiet> HoaDonChiTiets { get; set; }

    }
}
