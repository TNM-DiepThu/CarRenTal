using CarRenTal.View._7.QuanLyTaiKhoan;
using CarRenTal.View.QuanLyChoThueXe;
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
using static System.Net.WebRequestMethods;
using ZXing.QrCode.Internal;

namespace CarRenTal.View.MainView
{
    public partial class MainViewQL : Form
    {
        //public readonly LogoutSuccessFull { get; set; }
        TaiKhoan _tk = new TaiKhoan();
        public MainViewQL(TaiKhoan tk)
        {
          
            _tk = tk;
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Font;
        }

        public MainViewQL()
        {
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close(); // if form open is close
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;  // close form firt
            childForm.FormBorderStyle = FormBorderStyle.None; // of window controls
            childForm.Dock = DockStyle.Fill;
            pn_main.Controls.Add(childForm);
            pn_main.BringToFront();
            childForm.Show();
        }

        private void ChangeBackGroundButton(Button buttonAction)
        {
            btnChoThueXe.BackColor = Color.White;
            btnQLCTX.BackColor = Color.White;
            btnQLX.BackColor = Color.White;
            btnQLHD.BackColor = Color.White;
            btnQLNV.BackColor = Color.White;
            btnQLKH.BackColor = Color.White;
            btnQLTC.BackColor = Color.White;
            btnDangXuat.BackColor = Color.White;

            buttonAction.BackColor = Color.LightBlue;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.QuanLyChoThueXe.QLCTXView(_tk.NhanVien));
            ChangeBackGroundButton(btnQLCTX);
            //btnQLCTX.BackColor = Color.Blue;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainViewQL_Load(object sender, EventArgs e)
        {
            btnChoThueXe_Click(null, null);
            CheckPower();
        }

        private void CheckPower()
        {
            if (_tk.NhanVien.ChucVu.TenChucVu == "Quản lý")
            {
                return;
            }

            btnQLX.Visible = false;
            btnQLHD.Visible = false;
            btnQLNV.Visible = false;
            btnQLKH.Visible = false;
            btnQLTC.Visible = false;

        }

        private void btnQLX_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLiXeView());
            ChangeBackGroundButton(btnQLX);

        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View._4._QuanLyHoaDon.QLHDDView());
            ChangeBackGroundButton(btnQLHD);
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View._7.QuanLyTaiKhoan.QuanLyTaiKhoan());
            ChangeBackGroundButton(btnQLNV);
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View._5._QuanLyKhachHang.QLKHView());
            ChangeBackGroundButton(btnQLKH);
        }

        private void btnQLTC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View._6.QuanLyThuChi.QLCTView());
            ChangeBackGroundButton(btnQLTC);
        }

        public void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyTaiKhoan());
            ChangeBackGroundButton(btnDangXuat);
        }

        public void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChoThueXe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View._1.ChoThueXe.ChoThueXeForm(_tk.NhanVien));
            ChangeBackGroundButton(btnChoThueXe);
        }

        private void MainViewQL_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
