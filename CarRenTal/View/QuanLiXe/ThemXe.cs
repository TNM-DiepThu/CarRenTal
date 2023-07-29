using Bus.Serviece.Implements;
using Bus.Serviece.Interface;
using Bus.ViewModal;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRenTal.View.QuanLiXe
{
    public partial class ThemXe : Form
    {
        IXeServiece _xesv;
        IMauSacServiece _mauSacServiece;
        ILoaiXeServiece _loaiXeServiece;
        IDangKiemServiece _dk;
        Guid _id;
        Guid _id2;
        public ThemXe()
        {
            _xesv = new XeServiece();
            _mauSacServiece = new MauSacServiece();
            _loaiXeServiece = new LoaiXeServiece();
            _dk = new DangKiemServiece();
            InitializeComponent();
            addCCB();
        }
        private void addCCB()
        {
            cb_mausac.Items.Clear(); // Xóa các phần tử cũ (nếu có)
            foreach (var x in _mauSacServiece.GetAll())
            {
                cb_mausac.Items.Add(x.TenMauSac);
            }
            cb_name.Items.Clear(); // Xóa các phần tử cũ (nếu có)
            foreach (var x in _loaiXeServiece.GetAll())
            {
                cb_name.Items.Add(x.Name);
            }
        }
        
        private XeVM GetDaTa()
        {
            XeVM xes = new XeVM();
            {
                xes.BienSo = tb_bienso.Text;
                xes.SoKhung = tb_sokhung.Text;
                xes.SoMay = tb_somay.Text;
                xes.DonGia = decimal.Parse(tb_dongia.Text);
                if (int.TryParse(tb_sct.Text, out int soCongTo))
                {
                    xes.SoCongTo = soCongTo;
                }
                else
                {
                    MessageBox.Show("giá trị ko hợp lệ");
                }
                xes.TrangThai = rd_0.Checked ? 0 : 1;
                xes.TenXe = cb_name.Text;
                xes.MauSac = cb_mausac.Text;
            }
            return xes;
        }
        private DangKiem GetDataDK()
        {
            
            DangKiem dangKiem = new DangKiem();
            {               
                dangKiem.NgayDangKiem =DateTime.Parse(dtp_ndk.Text);
                dangKiem.NgayHetHan = DateTime.Parse(dtp_nhh.Text);
                dangKiem.ChiPhi = int.Parse( tb_chiphi.Text);               
            }
            return dangKiem;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (_xesv.Add(GetDaTa(), GetDataDK()))
            {

                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
            }
           
        }
    }

