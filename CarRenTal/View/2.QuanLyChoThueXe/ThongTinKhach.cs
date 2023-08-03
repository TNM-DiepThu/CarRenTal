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

namespace CarRenTal.View._2.QuanLyChoThueXe
{
    public partial class ThongTinKhach : Form
    {
        KhachHang kh;
        public ThongTinKhach()
        {
            InitializeComponent();
        }
        public ThongTinKhach(KhachHang khach)
        {
            InitializeComponent();
            kh = khach;
        }

        private void ThongTinKhach_Load(object sender, EventArgs e)
        {
            tx_name.Text = kh.Name;
            tx_dob.Text = kh.NgaySinh.Day.ToString() + "/" + kh.NgaySinh.Month.ToString() + "/" + kh.NgaySinh.Year.ToString();
            tx_pNum.Text = kh.SDT;
            tx_sex.Text = kh.GioiTinh ? "Nam" : "Nữ";
            tx_vnID.Text = kh.CCCD;
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
