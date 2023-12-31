﻿using Bus.Serviece.Implements;
using Bus.Serviece.Interface;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.ViewModal
{
    public class XeVM
    {

        public XeVM()
        {

        }
        IXeBaoHiemServiece _baohiem;
        IDangKiemServiece _dangkiem;
        IXeServiece _xe;
        IBaoDuongServiece _bo;
        public Guid ID { get; set; }
        public string BienSo { get; set; }
        public string SoKhung { get; set; }
        public string SoMay { get; set; }
        public decimal DonGia { get; set; }
        public int SoCongTo { get; set; }
        public int TrangThai { get; set; }
        public int SoGhe { get; set; }
        public string MauSac { get; set; }
        public string TrangThaiDangKiem { get; set; }
        public string TrangThaiBaoHiem { get; set; }
        public Guid IdBaoHiem { get; set; }
        public string TenHangXe { get; set; }
        public string TenXe { get; set; }
        public DateTime NgayKetThucBaoHiem { get; set; }
        public DateTime NgayHetHanDangKiem { get; set; }
        public int TrangThaiBaoDuong {get; set;}

        public XeVM(Xe x)
        {
            _baohiem = new XeBaoHiemServiece();
            _dangkiem = new DangKiemServiece();
            _bo = new BaoDuongServiece();
            _xe = new XeServiece();
            this.ID = x.ID;
            this.TenXe = _xe.GetTenLoaiXe(x.IdLoaiXe);
            this.BienSo = x.BienSo;
            this.SoKhung = x.SoKhung;
            this.SoMay = x.SoMay;
            this.DonGia = x.DonGia;
            this.SoCongTo = x.SoCongTo;
            this.TrangThai = x.TrangThai;
            this.MauSac = _xe.GetMauSacName(x.IdMauSac);
            this.SoGhe = _xe.GetLoaiXe(x.IdLoaiXe);

            this.TenHangXe = _xe.GetTenHangXe(x.IdLoaiXe);

            this.NgayKetThucBaoHiem = _baohiem.NgayHHBaoHiem(x.ID);
            if (NgayKetThucBaoHiem > DateTime.Now && NgayKetThucBaoHiem <= DateTime.Now.AddDays(7))
            {
                TrangThaiBaoHiem = "Sắp hết hạn";
            }
            else

           if (NgayKetThucBaoHiem > DateTime.Now.AddDays(7))
            {
                TrangThaiBaoHiem = "Còn hạn";
            }

            else
            {
                TrangThaiBaoHiem = "Hết hạn";
            }


            this.NgayHetHanDangKiem = _dangkiem.NgayHHDangKiem(x.ID);
            if (NgayHetHanDangKiem > DateTime.Now && NgayHetHanDangKiem <= DateTime.Now.AddDays(7))
            {
                TrangThaiDangKiem = "Sắp hết hạn";
            }
            else
            if (NgayHetHanDangKiem > DateTime.Now.AddDays(7))
            {
                TrangThaiDangKiem = "Còn hạn";
            }

            else
            {
                TrangThaiDangKiem = "Hết hạn";
            }
            this.TrangThaiBaoDuong = _bo.GetTrangThaiBaoDuong(x.ID);
        }
    }
}
