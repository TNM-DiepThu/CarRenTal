using Bus;
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

namespace CarRenTal.View._7.QuanLyTaiKhoan
{
    public partial class QuanLyTaiKhoan : Form
    {
        TaiKhoanService _taiKhoanService = new TaiKhoanService();

        List<NhanVien> _lstNhanVien;
        List<ChucVu> _lstChucVu;
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            _lstNhanVien = _taiKhoanService.GetDataGrid("");

        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            dtgv_data.Rows.Clear();
            dtgv_data.ColumnCount = 7;
            dtgv_data.Columns[0].HeaderText = "ID";
            dtgv_data.Columns[1].HeaderText = "Họ và tên";
            dtgv_data.Columns[2].HeaderText = "Giới tính";
            dtgv_data.Columns[3].HeaderText = "Số điện thoại";
            dtgv_data.Columns[4].HeaderText = "Email";
            dtgv_data.Columns[5].HeaderText = "Địa chỉ";
            dtgv_data.Columns[6].HeaderText = "Ngày sinh";



            foreach (var item in _lstNhanVien)
            {
                dtgv_data.Rows.Add(item.Id, item.HoTen, (item.GioiTinh ? "Nam" : "Nữ"), item.SDT, item.Email, item.DiaChi, item.NgaySinh);
            }
        }

        private void dtgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_data.CurrentRow != null)
            {
                lb_id.Text = dtgv_data.CurrentRow.Cells[0].Value.ToString();
                tx_hoTen.Text = dtgv_data.CurrentRow.Cells[1].Value.ToString();
                cbb_gioiTinh.SelectedIndex = dtgv_data.CurrentRow.Cells[2].Value.ToString() == "Nam" ? 0 : 1;
                tx_sdt.Text = dtgv_data.CurrentRow.Cells[3].Value.ToString();
                tx_email.Text = dtgv_data.CurrentRow.Cells[4].Value.ToString();
                tx_adress.Text = dtgv_data.CurrentRow.Cells[5].Value.ToString();
                dtp_dob.Value = DateTime.Parse(dtgv_data.CurrentRow.Cells[6].Value.ToString());
                TaiKhoan taiKhoan = _taiKhoanService.FindTaiKhoan(Guid.Parse(lb_id.Text));
                tx_user.Text = taiKhoan.username;
                tx_pass.Text = taiKhoan.password;
            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            lb_id.Text = "";
            tx_hoTen.Text = "";
            cbb_gioiTinh.SelectedValue = dtgv_data.CurrentRow.Cells[2].Value.ToString();
            tx_sdt.Text = "";
            tx_email.Text = "";
            tx_adress.Text = "";
            tx_user.Text = "";
            tx_pass.Text = "";
            dtp_dob.Value = DateTime.Today;
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            if (tx_search.Text != null)
            {
                _lstNhanVien = _taiKhoanService.GetDataGrid(tx_search.Text);
                QuanLyTaiKhoan_Load(null, null);
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if ()
            {

            }
        }
    }
}
