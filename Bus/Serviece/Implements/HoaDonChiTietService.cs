using Dal.Modal;
using Dal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    
    public class HoaDonChiTietService
    {
        HoaDonChiTietRepo HDCTRepo;
        List<HoaDonChiTiet> _lstHDCT;

        XeRepo XeRepo;
        List<Xe> _lstXe;

        ChiPhiPhatSinhRepo CPSTRepo;
        List<ChiPhiPhatSinh> _lstCPPS;


        public HoaDonChiTietService()
        {
            _lstHDCT = new List<HoaDonChiTiet>();
            _lstXe = new List<Xe>();
            _lstCPPS = new List<ChiPhiPhatSinh> ();
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return HDCTRepo.GetALL().ToList();
        }

        public bool CreateHDCT (HoaDonChiTiet hdct)
        {
            return HDCTRepo.Create(hdct);
        }
        public bool UpdateHDCT(HoaDonChiTiet hdct)
        {
            return HDCTRepo.Update(hdct);
        }

        public List<Xe> GetListXe (Guid Idxe)
        {
            var rusult = from x in _lstXe
                         join hd in _lstHDCT on x.ID equals hd.IdXe
                         where hd.TrangThai == 1
                         select x;

            return rusult.ToList();
        } 

    }
}
