using Bus.Serviece.Implements;
using Dal.Modal;
using Dal.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRenTal.View._5._QuanLyKhachHang
{
    public partial class QLKHView : Form
    {
        List<KhachHang> _lstKhachHang;
        KhachHangService _kHService;
        List<NguoiThan> _lstNguoiThan;
        NguoiThanService _NTService;


        public event EventHandler MyEventHandler;
        public QLKHView()
        {
            InitializeComponent();
            _lstKhachHang = new List<KhachHang>();
            _kHService = new KhachHangService();
            _lstNguoiThan = new List<NguoiThan>();
            _NTService = new NguoiThanService();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void GetDGV()
        {
            dgvQLKH.Rows.Clear();
            dgvQLKH.ColumnCount = 7;

            dgvQLKH.Columns[0].Name = "Mã KH";
            dgvQLKH.Columns[0].Visible = false;
            dgvQLKH.Columns[1].Name = "Họ và tên";
            dgvQLKH.Columns[2].Name = "Giới tính";
            dgvQLKH.Columns[3].Name = "Địa Chỉ";
            dgvQLKH.Columns[4].Name = "SĐT";
            dgvQLKH.Columns[5].Name = "Số CCCD";
            dgvQLKH.Columns[6].Name = "Ngày sinh";


            _lstKhachHang = _kHService.GetALL();

            foreach (var i in _lstKhachHang)
            {
                dgvQLKH.Rows.Add(i.Id, i.Name, (i.GioiTinh ? "Nam" : "Nữ"), i.DiaChi, i.SDT, i.CCCD, i.NgaySinh);
            }
        }

        private void QLKHView_Load(object sender, EventArgs e)
        {
            GetDGV();
        }

        private void dgvHistoryCTX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvQLKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TTKHchiTiet formKH = new TTKHchiTiet(this);
            formKH.Show();
        }



        private void dgvQLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textIDkh.Text = dgvQLKH.CurrentRow.Cells[0].Value.ToString();
            txtHoTenKH.Text = dgvQLKH.CurrentRow.Cells[1].Value.ToString();
            cbbGioiTinhKH.SelectedIndex = dgvQLKH.CurrentRow.Cells[2].Value.ToString() == "Nam" ? 0 : 1;
            txtDiaChiKH.Text = dgvQLKH.CurrentRow.Cells[3].Value.ToString();
            txtSdtKH.Text = dgvQLKH.CurrentRow.Cells[4].Value.ToString();
            txtCCCDKH.Text = dgvQLKH.CurrentRow.Cells[5].Value.ToString();
            dtpNgaySinhKh.Value = DateTime.Parse(dgvQLKH.CurrentRow.Cells[6].Value.ToString());

            KhachHang khach = new KhachHang();
            NguoiThan nguoiThan = _NTService.GetNguoiThan(Guid.Parse(textIDkh.Text));
            if (nguoiThan == null)
            {
                txtHoTenTn.Text = "";
                cbbGioiTinhTN.Text = "";
                txtDiaChiTn.Text = "";
                txtSDTTn.Text = "";
                txtCCCDTn.Text = "";
                MessageBox.Show("Người thân không tồn tại");
                return;
            }
            else
            {
                txtIDNT.Text = nguoiThan.Id.ToString();
                txtHoTenTn.Text = nguoiThan.Name;
                cbbGioiTinhTN.SelectedIndex = nguoiThan.GioiTinh ? 0 : 1;
                txtDiaChiTn.Text = nguoiThan.DiaChi;
                txtSDTTn.Text = nguoiThan.SDT;
                txtCCCDTn.Text = nguoiThan.CCCD;
            }

            decimal[] result = _kHService.GetNumberXe(Guid.Parse(textIDkh.Text));

            if (result != null)
            {
                lbSoLuongXe.Text = result[0].ToString();
                lbTongTienKhachThue.Text = result[1].ToString();
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                _kHService.CreateKhachHang(new KhachHang()
                {
                    Id = Guid.NewGuid(),
                    Name = txtHoTenKH.Text,
                    GioiTinh = cbbGioiTinhKH.SelectedIndex == 0 ? true : false,
                    DiaChi = txtDiaChiKH.Text,
                    SDT = txtSdtKH.Text,
                    CCCD = txtCCCDKH.Text,
                    NgaySinh = DateTime.Parse(dtpNgaySinhKh.Text)
                });
                MessageBox.Show("Thêm thành công");
                QLKHView_Load(null, null);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            try
            {
                string regex = regexInfo(txtHoTenKH.Text, cbbGioiTinhKH.SelectedIndex, txtDiaChiKH.Text, txtSdtKH.Text, txtCCCDKH.Text, dtpNgaySinhKh.Text);
                if (regex != null)
                {
                    MessageBox.Show("" + regex);
                    return;
                }
                KhachHang khachHang = new KhachHang()
                {
                    Id = Guid.Parse(textIDkh.Text),
                    Name = txtHoTenKH.Text,
                    GioiTinh = cbbGioiTinhKH.SelectedIndex == 0 ? true : false,
                    DiaChi = txtDiaChiKH.Text,
                    SDT = txtSdtKH.Text,
                    CCCD = txtCCCDKH.Text,
                    NgaySinh = DateTime.Parse(dtpNgaySinhKh.Text)
                };
                _kHService.UpdateKhachHang(khachHang);
                MessageBox.Show("Sửa thành công");
                QLKHView_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại" + "Lỗi: " + ex.Message);
            }
        }
        string regexInfo(string name, int gioiTinh, string diaChi, string sdt, string cccd, string ngaySinh)
        {
            //regex Full Name
            string paramater = @"^[AÀẢÃÁẠĂẰẲẴẮẶÂẦẨẪẤẬBCDĐEÈẺẼÉẸÊỀỂỄẾỆFGHIÌỈĨÍỊJKLMNOÒỎÕÓỌÔỒỔỖỐỘƠỜỞỠỚỢPQRSTUÙỦŨÚỤƯỪỬỮỨỰVWXYỲỶỸÝỴZ][aàảãáạăằẳẵắặâầẩẫấậbcdđeèẻẽéẹêềểễếệfghiìỉĩíịjklmnoòỏõóọôồổỗốộơờởỡớợpqrstuùủũúụưừửữứựvwxyỳỷỹýỵz]+ [AÀẢÃÁẠĂẰẲẴẮẶÂẦẨẪẤẬBCDĐEÈẺẼÉẸÊỀỂỄẾỆFGHIÌỈĨÍỊJKLMNOÒỎÕÓỌÔỒỔỖỐỘƠỜỞỠỚỢPQRSTUÙỦŨÚỤƯỪỬỮỨỰVWXYỲỶỸÝỴZ][aàảãáạăằẳẵắặâầẩẫấậbcdđeèẻẽéẹêềểễếệfghiìỉĩíịjklmnoòỏõóọôồổỗốộơờởỡớợpqrstuùủũúụưừửữứựvwxyỳỷỹýỵz]+(?: [AÀẢÃÁẠĂẰẲẴẮẶÂẦẨẪẤẬBCDĐEÈẺẼÉẸÊỀỂỄẾỆFGHIÌỈĨÍỊJKLMNOÒỎÕÓỌÔỒỔỖỐỘƠỜỞỠỚỢPQRSTUÙỦŨÚỤƯỪỬỮỨỰVWXYỲỶỸÝỴZ][aàảãáạăằẳẵắặâầẩẫấậbcdđeèẻẽéẹêềểễếệfghiìỉĩíịjklmnoòỏõóọôồổỗốộơờởỡớợpqrstuùủũúụưừửữứựvwxyỳỷỹýỵz]*)*";
            Regex regex = new Regex(paramater);
            if (!regex.IsMatch(name))
            {
                return "Họ và tên không phù hợp";
            }

            //regex gioi tinh

            if (gioiTinh != 1 && gioiTinh != 0)
            {
                return "Giới tính không hợp lệ";
            }

            //regex Address

            if (diaChi.Length <= 10)
            {
                return "Địa chỉ phải đầy đủ xã, huyện, phường";
            }

            //regex SĐT
            //Regex regex1 = new Regex(@"^(0 | 84)(2(0[3 - 9] | 1[0 - 6 | 8 | 9] | 2[0 - 2 | 5 - 9] | 3[2 - 9] | 4[0 - 9] | 5[1 | 2 | 4 - 9] | 6[0 - 3 | 9] | 7[0 - 7] | 8[0 - 9] | 9[0 - 4 | 6 | 7 | 9]) | 3[2 - 9] | 5[5 | 6 | 8 | 9] | 7[0 | 6 - 9] | 8[0 - 6 | 8 | 9] | 9[0 - 4 | 6 - 9])([0 - 9]{ 7 })$");
            paramater = @"0(3\d{8}|9\d{8}|8\d{8}|5\d{8}|7\d{8})";
            regex = new Regex(paramater);
            if (!regex.IsMatch(sdt))
            {
                return "số điện thoại không hợp lệ";
            }
            Regex regex2 = new Regex(@"^(?=.*?[0-9])$");
            // regex CCCD 
            if (cccd.Length != 12 && !regex2.IsMatch(cccd))
            {
                return "Căn cước công dân phải là 12 ký tự và phải là số";
            }
            // regex ngaysinh
            return null;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                QLKHView_Load(null, null);
            }
            dgvQLKH.Rows.Clear();

            dgvQLKH.ColumnCount = 7;

            dgvQLKH.Columns[0].Name = "Mã KH";
            dgvQLKH.Columns[1].Name = "Họ và tên";
            dgvQLKH.Columns[2].Name = "Giới tính";
            dgvQLKH.Columns[3].Name = "Địa Chỉ";
            dgvQLKH.Columns[4].Name = "SĐT";
            dgvQLKH.Columns[5].Name = "Số CCCD";
            dgvQLKH.Columns[6].Name = "Ngày sinh";

            _lstKhachHang = _kHService.GetALL();

            foreach (var i in _lstKhachHang.Where(c => c.Name.ToLower().Contains(txtSearch.Text.ToLower())))
            {
                dgvQLKH.Rows.Add(i.Id, i.Name, (i.GioiTinh ? "Nam" : "Nữ"), i.DiaChi, i.SDT, i.CCCD, i.NgaySinh);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHoTenKH.Text = "";
            cbbGioiTinhKH.Text = "";
            dtpNgaySinhKh.Text = DateTime.Today.ToString();
            txtCCCDKH.Text = "";
            txtDiaChiKH.Text = "";
            txtSdtKH.Text = "";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateTn_Click(object sender, EventArgs e)
        {
            try
            {
                _NTService.CreateNguoiThan(new NguoiThan()
                {
                    Id = Guid.NewGuid(),
                    Name = txtHoTenTn.Text,
                    GioiTinh = cbbGioiTinhTN.SelectedIndex == 0 ? true : false,
                    DiaChi = txtDiaChiTn.Text,
                    SDT = txtSDTTn.Text,
                    CCCD = txtCCCDTn.Text,
                    IdKhachHang = Guid.Parse(textIDkh.Text)
                });
                MessageBox.Show("Thêm thành công");
                QLKHView_Load(null, null);
            }
            catch (Exception)
            {

                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnUpdateTn_Click(object sender, EventArgs e)
        {
            try
            {
                string regex = regexInfo(txtHoTenTn.Text, cbbGioiTinhTN.SelectedIndex, txtDiaChiTn.Text, txtSDTTn.Text, txtCCCDTn.Text, "abc");
                if (regex != null)
                {
                    MessageBox.Show("" + regex);
                    return;
                }
                _NTService.UpdateNguoiThan(new NguoiThan()
                {
                    Id = Guid.Parse(txtIDNT.Text),
                    Name = txtHoTenTn.Text,
                    GioiTinh = cbbGioiTinhTN.SelectedIndex == 0 ? true : false,
                    DiaChi = txtDiaChiTn.Text,
                    SDT = txtSDTTn.Text,
                    CCCD = txtCCCDTn.Text,
                    IdKhachHang = Guid.Parse(textIDkh.Text)
                });
                MessageBox.Show("Sủa thành công");
                QLKHView_Load(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sửa thất bại" + "Lỗi: " + ex);
            }
        }

        private void btnClearTTTN_Click(object sender, EventArgs e)
        {
            txtHoTenTn.Text = "";
            cbbGioiTinhTN.Text = "";
            txtCCCDTn.Text = "";
            txtDiaChiTn.Text = "";
            txtSDTTn.Text = "";
        }
    }
}
