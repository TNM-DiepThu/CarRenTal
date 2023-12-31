﻿using Dal.Modal;
using Dal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    public class HoaDonService
    {
        TheChapRepo theChapRepo = new TheChapRepo();
        HoaDonThueXeRepo hoaDonRepo = new HoaDonThueXeRepo();

        HoaDonChiTietRepo hoaDonChiTietRepo = new HoaDonChiTietRepo();

        public int CheckHoaDon(HoaDonThueXe hd)
        {
            if (hd==null)
            {
                return -1;
            }
            hd.HoaDonChiTiets = hoaDonChiTietRepo.GetALL().Where(p => p.IdHoaDon == hd.Id).ToList();
            int hoanThanh = 0, thucHien = 0, huy = 0, soLuong = 0;
            foreach (var hdct in hd.HoaDonChiTiets)
            {
                soLuong++;
                if (hdct.TrangThai == 0)
                {
                    huy++;
                }
                if (hdct.TrangThai == 1 || hdct.TrangThai == 2)
                {
                    thucHien++;
                }
                if (hdct.TrangThai == 3||hdct.TrangThai==4||hdct.TrangThai==5)
                {
                    hoanThanh++;
                }
            }
            if (hoanThanh == soLuong)
            {
                hd.TrangThai = 4;

            }
            else if (huy == soLuong)
            {
                hd.TrangThai = 0;

            }
            else if (thucHien == soLuong)
            {
                hd.TrangThai = 1;

            }
            else if (hoanThanh > 0)
            {
                hd.TrangThai = 3;

            }
            else hd.TrangThai = 2;
            hoaDonRepo.Update(hd);
            return hd.TrangThai;



        }

        public void CreateTheChap(TheChap theChap)
        {
            theChapRepo.Create(theChap);
        }

        public void DeleteTheChap(Guid id)
        {
            theChapRepo.Delete(id);
        }

        public void UpdateHoaDon(HoaDonChiTiet hdct)
        {
            hoaDonChiTietRepo.Update(hdct);
        }

        public void UpdateTheChap(TheChap theChap)
        {
            theChapRepo.Update(theChap);
        }
    }
}
