using Bus.Serviece.Implements;
using Bus.Serviece.Interface;
using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.ViewModal
{
    public class XeBaoHiemVM
    {
        public XeBaoHiemVM()
        {

        }
        IBaoHiemServiece _sv;
        public Guid Id { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public decimal ChiPhi { get; set; }
        public int TrangThai { get; set; }
        public string LoaiBaoHiem { get; set; }
        public Guid IdXe { get; set; }
        public Guid IdBH { get; set; }
       
        public XeBaoHiemVM(XeBaoHiem x)
        {
            _sv = new BaoHiemServiece();
            this.Id = x.Id;
            this.NgayBatDau = x.NgayBatDau;
            this.NgayKetThuc = x.NgayKetThuc;
            this.ChiPhi = x.ChiPhi;
            this.TrangThai = x.TrangThai;
            this.LoaiBaoHiem = _sv.GetTenBaoHiem(x.IdHangBaoHiem);
            this.IdXe = x.IdXe;
        }
    }
}
