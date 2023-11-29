using Bus;
using Dal.Modal;
using Dal.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRenTal.View._7.QuanLyTaiKhoan
{
    public partial class QuanLyTaiKhoan : Form
    {
        public bool checkCreat = false;
        TaiKhoanService _taiKhoanService = new TaiKhoanService();

        List<NhanVien> _lstNhanVien;
        List<TaiKhoan> _lstTaiKhoan;

        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            _lstNhanVien = _taiKhoanService.GetDataGrid("");

        }

        public void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            dtgv_data.Rows.Clear();
            dtgv_data.ColumnCount = 7;
            dtgv_data.Columns[0].HeaderText = "ID";
            dtgv_data.Columns[0].Visible = false;
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

        public void bt_add_Click(object sender, EventArgs e)
        {
            string regexKQ = RegexInfor(tx_hoTen.Text, cbb_gioiTinh.SelectedIndex, tx_sdt.Text, tx_email.Text, tx_adress.Text, tx_user.Text, tx_pass.Text, "add");
            if (regexKQ != null)
            {
                MessageBox.Show("" + regexKQ);
                return;
            }
            NhanVien nhanVien = new NhanVien()
            {
                DiaChi = tx_adress.Text,
                Email = tx_email.Text,
                GioiTinh = cbb_gioiTinh.SelectedIndex == 0 ? true : false,
                HoTen = tx_hoTen.Text,
                Id = Guid.NewGuid(),
                NgaySinh = dtp_dob.Value,
                SDT = tx_sdt.Text,
                TrangThai = 1,
                IdChucVu = Guid.NewGuid(),
            };
            bool AddNV = _taiKhoanService.CreateNhanVien(nhanVien);
            TaiKhoan taiKhoan = new TaiKhoan()
            {
                username = tx_user.Text,
                password = tx_pass.Text,
                TrangThai = 1,
                IdNhanVien = nhanVien.Id,
            };
            bool AddTK = _taiKhoanService.CreateTaiKhoan(taiKhoan);
            if (AddNV && AddTK)
            {
                checkCreat =true;
                MessageBox.Show("Thành công");
                _lstNhanVien.Add(nhanVien);
                QuanLyTaiKhoan_Load(null, null);
            }
            else
            {
                checkCreat = false;
                MessageBox.Show("Thất bại");
            }

        }
        string RegexInfor(string name, int gTinh, string sdt, string email, string adress, string user, string pass, string type)
        {
            //regexEmail
            string paramater = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(paramater);
            if (!regex.IsMatch(email))
            {
                return "Email không hợp lệ";
            }
            //regex họ tên
            paramater = @"^[AÀẢÃÁẠĂẰẲẴẮẶÂẦẨẪẤẬBCDĐEÈẺẼÉẸÊỀỂỄẾỆFGHIÌỈĨÍỊJKLMNOÒỎÕÓỌÔỒỔỖỐỘƠỜỞỠỚỢPQRSTUÙỦŨÚỤƯỪỬỮỨỰVWXYỲỶỸÝỴZ][aàảãáạăằẳẵắặâầẩẫấậbcdđeèẻẽéẹêềểễếệfghiìỉĩíịjklmnoòỏõóọôồổỗốộơờởỡớợpqrstuùủũúụưừửữứựvwxyỳỷỹýỵz]+ [AÀẢÃÁẠĂẰẲẴẮẶÂẦẨẪẤẬBCDĐEÈẺẼÉẸÊỀỂỄẾỆFGHIÌỈĨÍỊJKLMNOÒỎÕÓỌÔỒỔỖỐỘƠỜỞỠỚỢPQRSTUÙỦŨÚỤƯỪỬỮỨỰVWXYỲỶỸÝỴZ][aàảãáạăằẳẵắặâầẩẫấậbcdđeèẻẽéẹêềểễếệfghiìỉĩíịjklmnoòỏõóọôồổỗốộơờởỡớợpqrstuùủũúụưừửữứựvwxyỳỷỹýỵz]+(?: [AÀẢÃÁẠĂẰẲẴẮẶÂẦẨẪẤẬBCDĐEÈẺẼÉẸÊỀỂỄẾỆFGHIÌỈĨÍỊJKLMNOÒỎÕÓỌÔỒỔỖỐỘƠỜỞỠỚỢPQRSTUÙỦŨÚỤƯỪỬỮỨỰVWXYỲỶỸÝỴZ][aàảãáạăằẳẵắặâầẩẫấậbcdđeèẻẽéẹêềểễếệfghiìỉĩíịjklmnoòỏõóọôồổỗốộơờởỡớợpqrstuùủũúụưừửữứựvwxyỳỷỹýỵz]*)*";
            regex = new Regex(paramater);
            if (!regex.IsMatch(name))
            {
                return "Họ tên không hợp lệ";
            }
            //regex số điện thoại
            paramater = @"0(3\d{8}|9\d{8}|8\d{8}|5\d{8}|7\d{8})";
            regex = new Regex(paramater);
            if (!regex.IsMatch(sdt))
            {
                return "Số điện thoại không hợp lệ";
            }
            if (gTinh != 1 && gTinh != 0)
            {
                return "Giới tính không hợp lệ";
            }
            if (adress.Length <= 4)
            {
                return "Địa chỉ phải dài hơn 4 ký tự";
            }
            if (user.Length <= 4)
            {
                return "Tên đăng nhập dài hơn 4 ký tự";
            }
            if (type == "add" && _taiKhoanService.CheckUser(user))
            {
                return "Tài khoản đã tồn tại";
            }
            if (pass.Length < 1)
            {
                return "Mật khẩu có ít nhất 1 ký tự";
            }
            return null;


        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string regexKQ = RegexInfor(tx_hoTen.Text, cbb_gioiTinh.SelectedIndex, tx_sdt.Text, tx_email.Text, tx_adress.Text, tx_user.Text, tx_pass.Text, "update");
            if (regexKQ != null)
            {
                MessageBox.Show("" + regexKQ);
                return;
            }
            NhanVien nhanVien = new NhanVien()
            {
                DiaChi = tx_adress.Text,
                Email = tx_email.Text,
                GioiTinh = cbb_gioiTinh.SelectedIndex == 0 ? true : false,
                HoTen = tx_hoTen.Text,
                Id = Guid.Parse(lb_id.Text),
                NgaySinh = dtp_dob.Value,
                SDT = tx_sdt.Text,
                TrangThai = 1,
                IdChucVu = Guid.NewGuid(),
            };
            bool AddNV = _taiKhoanService.UpdateNhanVien(nhanVien);
            TaiKhoan taiKhoan = new TaiKhoan()
            {
                username = tx_user.Text,
                password = tx_pass.Text,
                TrangThai = 1,
                IdNhanVien = nhanVien.Id,
            };
            bool AddTK = _taiKhoanService.UpdateTaiKhoan(taiKhoan);
            if (AddNV && AddTK)
            {
                MessageBox.Show("Thành công");
                _lstNhanVien.Remove(_lstNhanVien.FirstOrDefault(p => p.Id == Guid.Parse(lb_id.Text)));
                _lstNhanVien.Add(nhanVien);
                QuanLyTaiKhoan_Load(null, null);
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (lb_id.Text == null)
            {
                return;
            }
            NhanVien nhanVien = new NhanVien()
            {
                Id = Guid.Parse(lb_id.Text),
            };
            bool AddNV = _taiKhoanService.DeleteNhanVien(nhanVien);
            TaiKhoan taiKhoan = new TaiKhoan()
            {
                username = tx_user.Text,
                TrangThai = 1,
            };
            bool AddTK = _taiKhoanService.DeleteTaiKhoan(taiKhoan);
            if (AddNV && AddTK)
            {
                MessageBox.Show("Thành công");

                _lstNhanVien.Remove(_lstNhanVien.FirstOrDefault(p => p.Id == Guid.Parse(lb_id.Text)));
                QuanLyTaiKhoan_Load(null, null);
                bt_clear_Click(null, null);
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

    }
}
