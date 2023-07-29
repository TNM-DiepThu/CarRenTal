using Bus.Serviece.Implements;
using Bus.Serviece.Interface;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.ViewModal
{

    public class LoaiXeVM
    {
        public LoaiXeVM()
        {
            
        }
        IHangXeServiece _hangXeServiece;
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LoaiNguyenLieu { get; set; }
        public int SoGhe { get; set; }
        public string LoaiSoXe { get; set; }
        public int TrangThai { get; set; }
        public string TenHangXe { get; set; }
        public Guid IdHang { get; set; }
        public LoaiXeVM(LoaiXe loaiXe)
        {
            _hangXeServiece = new HangXeServiece();
            // Thực hiện chuyển đổi từ LoaiXe sang LoaiXeVM
            this.Id = loaiXe.Id;
            this.Name = loaiXe.Name;
            this.LoaiNguyenLieu = loaiXe.LoaiNguyenLieu;
            this.SoGhe = loaiXe.SoGhe;
            this.LoaiSoXe = loaiXe.LoaiSoXe;
            this.TrangThai = loaiXe.TrangThai;
            this.TenHangXe = _hangXeServiece.GetTenHangXe(loaiXe.IdHangXe);
        }
    }
}
