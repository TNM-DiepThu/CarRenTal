using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Modal
{
    public class HoaDonChiTiet
    {
       
        public Guid Id { get; set; }
        public DateTime NgayBatDau { get; set; }    
        public DateTime NgayKetThuc { get;set; }
        public decimal TongTien { get; set; }
        public decimal DonGia { get; set; }      
        public decimal TienCoc { get; set; }

        public int TrangThai { get; set; }
        public Guid IdHoaDon { get; set; }
        public virtual HoaDonThueXe HoaDonThueXe { get; set; }
        public Guid IdXe { get; set; }
        public virtual Xe Xe { get; set; }
        public ICollection<TheChap>  theChaps { get; set; }
        public ICollection<ChiPhiPhatSinh>  chiPhiPhatSinhs { get; set; }

    }
}
