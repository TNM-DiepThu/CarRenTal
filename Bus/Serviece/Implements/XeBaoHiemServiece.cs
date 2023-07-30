using Bus.Serviece.Interface;
using Bus.ViewModal;
using Dal.Data;
using Dal.Modal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    public class XeBaoHiemServiece : IXeBaoHiemServiece
    {
        CarRentalDBContext _context;
        public XeBaoHiemServiece()
        {
            _context = new CarRentalDBContext();
        }
        public List<XeBaoHiemVM> GetAll(Guid id)
        {
            List<XeBaoHiem> danhSachLoaiXe = _context.xeBaoHiems.ToList();

            // Chuyển đổi danh sách các loại xe sang danh sách các LoaiXeVM
            List<XeBaoHiemVM> danhSachLoaiXeVM = danhSachLoaiXe.Select(loaiXe => new XeBaoHiemVM(loaiXe))
                .Where(x => x.IdXe == id).ToList();

            return danhSachLoaiXeVM;
        }

        public DateTime NgayHHBaoHiem(Guid id)
        {
            XeBaoHiem baohiem = _context.xeBaoHiems.FirstOrDefault(h => h.IdXe == id);
            if (baohiem != null)
            {
                return baohiem.NgayKetThuc;
            }
            return DateTime.MinValue;
        }
        public bool Add(XeBaoHiemVM p, Guid id)
        {
            try
            {
                var bd = new XeBaoHiem();
                {
                    bd.Id = Guid.NewGuid();
                    bd.NgayBatDau = p.NgayBatDau;
                    bd.NgayKetThuc = p.NgayKetThuc;
                    bd.ChiPhi = p.ChiPhi;                   
                    bd.TrangThai = (p.NgayKetThuc < DateTime.Now) ? 1 : 0;
                    bd.IdXe = id;

                }
                BaoHiem lx = _context.baoHiems.FirstOrDefault(h => h.LoaiBaoHiem == p.LoaiBaoHiem);
                if (lx != null)
                {
                    bd.IdHangBaoHiem = lx.Id;
                }
                _context.Add(bd);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(XeBaoHiemVM p, Guid Id)
        {
            try
            {
                var bd = _context.xeBaoHiems.FirstOrDefault(x => x.Id == p.Id);
                if (bd != null)
                {
                    bd.NgayBatDau = p.NgayBatDau;
                    bd.NgayKetThuc = p.NgayKetThuc;
                    bd.ChiPhi = p.ChiPhi;               
                    bd.TrangThai = (p.NgayKetThuc < DateTime.Now) ? 1 : 0;
                    bd.IdXe = Id;
                    BaoHiem lx = _context.baoHiems.FirstOrDefault(h => h.LoaiBaoHiem == p.LoaiBaoHiem);
                    if (lx != null)
                    {
                        bd.IdHangBaoHiem = lx.Id;
                    }
                    _context.Update(bd);
                    _context.SaveChanges();
                    return true;
                }
                return false;

            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
