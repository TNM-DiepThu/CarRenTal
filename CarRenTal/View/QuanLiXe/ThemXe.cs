using Dal.Repository;
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
        LoaiXeRepo loaiXeRepo = new LoaiXeRepo();
        MauSacRepo mauSacRepo = new MauSacRepo();
        XeRepo XeRepo = new XeRepo();
        public ThemXe()
        {
            InitializeComponent();
            cbb_loaiXe.DataSource = loaiXeRepo.GetALL();
            cbb_loaiXe.DisplayMember = "Name";
            cbb_loaiXe.ValueMember = "Id";
            cbb_mau.DataSource = mauSacRepo.GetALL();
            cbb_mau.DisplayMember = "TenMauSac";
            cbb_mau.ValueMember = "Id";
        }


        private void ThemXe_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = XeRepo.GetXe();

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            XeRepo.CreateXe(new Dal.Modal.Xe()
            {
                BienSo=tx_bienSo.Text,
                SoCongTo= int.Parse(tx_congTo.Text),
                SoKhung= tx_soKhung.Text,
                SoMay=tx_soMay.Text,
                ID= Guid.NewGuid(),
                DonGia= decimal.Parse(tx_donGia.Text),
                IdLoaiXe= Guid.Parse(cbb_loaiXe.SelectedValue.ToString()),
                IdMauSac= Guid.Parse(cbb_mau.SelectedValue.ToString()),
                TrangThai= 1,
            });
            ThemXe_Load(null, null);
        }
    }

}
