using Dal.Modal;
using Dal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    
    public class XeService
    {
        XeRepo xeRepo = new XeRepo();
        List<Xe> _lstXe;
        LoaiXeRepo loaiXeRepo = new LoaiXeRepo();
        List<LoaiXe> _lstLoaiXe;
        ChiPhiPhatSinhRepo CPPSRepo = new ChiPhiPhatSinhRepo();
        List<ChiPhiPhatSinh> _lstChiPhiPhatSinh;

        Xe_BaoHiemRepo xe_BaoHiemRepo= new Xe_BaoHiemRepo();
        DangKiemRepo DangKiemRepo = new DangKiemRepo();
        BaoDuongRepo baoDuongRepo = new BaoDuongRepo();
        List<BaoHiem> _lstBHX;
        List<DangKiemRepo> _lstĐKX;
        List<BaoDuongRepo> _lstBDX;
        public XeService()
        {
                _lstXe = new List<Xe>();
            _lstLoaiXe = new List<LoaiXe>();
            _lstChiPhiPhatSinh = new List<ChiPhiPhatSinh>();
        }

        public List<Xe> GetAll()
        {
            return xeRepo.GetXe().ToList();
        }

        public List<XeBaoHiem> GetAllBHX()
        {
            return xe_BaoHiemRepo.GetAll().ToList();
        }
        public List<DangKiem> GetAllDKX()
        {
            return DangKiemRepo.GetALL().ToList();
        }
        public List<BaoDuong> GetAllBDX()
        {
            return baoDuongRepo.GetALL().ToList();
        }
        public List<ChiPhiPhatSinh> GetAllCPPS()
        {
            return CPPSRepo.GetALL().ToList();
        }


        public List<LoaiXe> GetAllLoaiXe()
        {
            return loaiXeRepo.GetALL().ToList();
        }

        public bool CreateXe(Xe xe)
        {
            return xeRepo.CreateXe(xe);
        }
        public bool UpdateXe(Xe xe)
        {
            return xeRepo.UpdateXe(xe);
        }
    }
}
