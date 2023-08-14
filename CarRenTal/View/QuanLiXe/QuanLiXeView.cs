using Bus.Serviece.Implements;
using Bus.Serviece.Interface;
using Bus.ViewModal;
using CarRenTal.View.QuanLiXe;
using Dal.Data;
using Dal.Modal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRenTal
{
    public partial class QuanLiXeView : Form
    {

        IXeServiece _xe;
        IXeBaoHiemServiece _baoHiem;
        IDangKiemServiece _dangkiem;
        IMauSacServiece _mau;
        IHangXeServiece _hangXe;
        private Guid selectedXeId;
        public QuanLiXeView()
        {
            InitializeComponent();
            _xe = new XeServiece();
            _baoHiem = new XeBaoHiemServiece();
            _dangkiem = new DangKiemServiece();
            _mau = new MauSacServiece();
            _hangXe = new HangXeServiece();
            LoadData();
            addCCB();
        }
        private void addCCB()
        {
            cb_seachms.Items.Clear();
            cb_seachms.Items.Add("");
            foreach (var x in _mau.GetAll())
            {
                cb_seachms.Items.Add(x.TenMauSac);

            }

            cb_seachhx.Items.Clear();
            cb_seachhx.Items.Add("");
            foreach (var x in _hangXe.GetAllHangXe())
            {
                cb_seachhx.Items.Add(x.Name);
            }
        }
        private void QuanLiXe_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private string GetTrangThaiAsString(int trangThai)
        {
            if (trangThai == 1)
            {
                return "Đang hoạt động";

            }
            if (trangThai == 0)
            {
                return "Ngừng hoạt động";
            }
            else
            {
                return "Bị xoá";

            }

        }
        private string TTBD(int trangThai)
        {
            if (trangThai == 1)
            {
                return "Đang đang bảo dưỡng";
            }
            if (trangThai == 0) // Loại bỏ dấu chấm phẩy ở đây
            {
                return "Kết thúc bảo dưỡng";
            }

            // Hãy đảm bảo bạn có xử lý cả trạng thái khác 0 và 1
            return "Trạng thái không xác định";
        }

        public void LoadData()
        {
            int stt = 1;
            dtg_show.ColumnCount = 14;
            dtg_show.Columns[0].Name = "STT";
            dtg_show.Columns[0].Width = 40;

            dtg_show.Columns[1].Name = "Id";
            dtg_show.Columns[1].Visible = false;
            dtg_show.Columns[2].Name = "Hãng Xe";
            dtg_show.Columns[3].Name = "Loại xe";
            dtg_show.Columns[4].Name = "Tên xe";
            dtg_show.Columns[5].Name = "Biển Số";
            dtg_show.Columns[6].Name = "Số khung";
            dtg_show.Columns[7].Name = "Số Máy";
            dtg_show.Columns[8].Name = "Đơn giá";
            dtg_show.Columns[9].Name = "Màu sắc";
            dtg_show.Columns[10].Name = "Trạng thái đăng kiếm";
            dtg_show.Columns[11].Name = "Trạng thái bảo hiểm";
            dtg_show.Columns[12].Name = "Trạng Thái bảo dưỡng";
            dtg_show.Columns[13].Name = "Trạng Thái";
            dtg_show.Rows.Clear();
            foreach (var x in _xe.GetAll())
            {
                string trangThaiAsString = GetTrangThaiAsString(x.TrangThai);
                string ttbd = TTBD(x.TrangThaiBaoDuong);
                string TenhangXe = x.TenHangXe;
                string TenXe = x.TenXe;
                int LoaiXe = x.SoGhe;



                dtg_show.Rows.Add(stt++, x.ID, TenhangXe, LoaiXe, TenXe, x.BienSo, x.SoKhung, x.SoMay, x.DonGia, x.MauSac, x.TrangThaiDangKiem, x.TrangThaiBaoHiem, ttbd, trangThaiAsString);
            }
        }


        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo chỉ xử lý khi người dùng chọn một hàng (không phải tiêu đề cột)
            {
                DataGridViewRow row = dtg_show.Rows[e.RowIndex];
                selectedXeId = (Guid)row.Cells["Id"].Value;
            }
        }

        private void bt_dk_Click(object sender, EventArgs e)
        {
            if (selectedXeId != Guid.Empty) // Đảm bảo đã chọn một xe trước khi mở Form BaoDuong
            {
                // Tạo Form mới chứa DataGridView của BaoDuong
                using (var baoDuongForm = new BaoDuongView(selectedXeId))
                {
                    baoDuongForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một xe trước khi thực hiện bảo dưỡng.");
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cb_lsg.Text, out int soGheFilter))
            {
                var filteredXes = _xe.GetAll().Where(x => x.SoGhe == soGheFilter);
                dtg_show.Rows.Clear();
                int stt = 1;
                foreach (var x in filteredXes)
                {
                    string trangThaiAsString = GetTrangThaiAsString(x.TrangThai);
                    string TenhangXe = x.TenHangXe;
                    int LoaiXe = x.SoGhe;

                    dtg_show.Rows.Add(stt++, x.ID, TenhangXe, LoaiXe, x.TenXe, x.BienSo, x.SoKhung, x.SoMay, x.DonGia, x.MauSac, x.TrangThaiDangKiem, x.TrangThaiBaoHiem, trangThaiAsString);
                }
            }
            else
            {
                // Nếu giá trị nhập vào không hợp lệ, hiển thị toàn bộ dữ liệu lên DataGridView
                LoadData();
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            using (var addform = new ThemXe(this))
            {
                addform.ShowDialog();
            }
        }

        private void tb_seach_TextChanged(object sender, EventArgs e)
        {
            string searchText = tb_seach.Text.ToLower();
            var filteredXes = _xe.GetAll().Where(x =>
                x.TenXe.ToLower().Contains(searchText) ||
                x.BienSo.ToLower().Contains(searchText));

            dtg_show.Rows.Clear();
            int stt = 1;
            foreach (var x in filteredXes)
            {
                string trangThaiAsString = GetTrangThaiAsString(x.TrangThai);
                string TenhangXe = x.TenHangXe;
                int LoaiXe = x.SoGhe;

                dtg_show.Rows.Add(stt++, x.ID, TenhangXe, LoaiXe, x.TenXe, x.BienSo, x.SoKhung, x.SoMay, x.DonGia, x.MauSac, x.TrangThaiDangKiem, x.TrangThaiBaoHiem, trangThaiAsString);
            }

        }
        private void DisplayFilteredXes(IEnumerable<XeVM> filteredXes)
        {
            dtg_show.Rows.Clear();
            int stt = 1;
            foreach (var x in filteredXes)
            {
                string trangThaiAsString = GetTrangThaiAsString(x.TrangThai);
                string TenhangXe = x.TenHangXe;
                int LoaiXe = x.SoGhe;

                dtg_show.Rows.Add(stt++, x.ID, TenhangXe, LoaiXe, x.TenXe, x.BienSo, x.SoKhung, x.SoMay, x.DonGia, x.MauSac, x.TrangThaiDangKiem, x.TrangThaiBaoHiem, trangThaiAsString);
            }
        }
        private void bt_hhdk_Click(object sender, EventArgs e)
        {
            var filteredXes = _xe.GetAll().Where(x => x.TrangThaiDangKiem == "Còn hạn");

            DisplayFilteredXes(filteredXes);
        }
        private void bt_dhdk_Click(object sender, EventArgs e)
        {
            var filteredXes = _xe.GetAll().Where(x => x.TrangThaiDangKiem == "Hết hạn");

            // Hiển thị kết quả lọc lên DataGridView
            DisplayFilteredXes(filteredXes);
        }


        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (selectedXeId != Guid.Empty) // Đảm bảo đã chọn một xe trước khi mở Form BaoDuong
            {
                // Tạo Form mới chứa DataGridView của BaoDuong
                using (var edit = new EditXeView(selectedXeId, this))
                {
                    edit.ShowDialog();

                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một xe trước khi thực hiện xem sửa.");
            }
        }
        public void RefreshDataGridView()
        {


        }

        private void bt_bh_Click(object sender, EventArgs e)
        {
            if (selectedXeId != Guid.Empty) // Đảm bảo đã chọn một xe trước khi mở Form BaoDuong
            {
                // Tạo Form mới chứa DataGridView của BaoDuong
                using (var bh = new XeBaoHiemView(selectedXeId, this))
                {
                    bh.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một xe trước khi thực hiện xem.");
            }
        }

        private void bt_dk_Click_1(object sender, EventArgs e)
        {
            if (selectedXeId != Guid.Empty) // Đảm bảo đã chọn một xe trước khi mở Form BaoDuong
            {
                // Tạo Form mới chứa DataGridView của BaoDuong
                using (var bh = new DangKiemView(selectedXeId))
                {
                    bh.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một xe trước khi thực hiện xem.");
            }
        }

        private void bt_hx_Click(object sender, EventArgs e)
        {
            var hangxe = new View.HangXeView();
            {
                hangxe.ShowDialog();
            }
        }

        private void bt_qllx_Click(object sender, EventArgs e)
        {
            var loaixe = new View.QuanLiXe.LoaiXeView();
            {
                loaixe.ShowDialog();
            }
        }

        private void cb_lsg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_seachms_TextChanged(object sender, EventArgs e)
        {
            string mausac = cb_seachms.Text;
            var filterms = _xe.GetAll().Where(x => x.MauSac.Contains(mausac));
            dtg_show.Rows.Clear();
            int stt = 1;
            foreach (var x in filterms)
            {
                string trangThaiAsString = GetTrangThaiAsString(x.TrangThai);
                string TenhangXe = x.TenHangXe;
                int LoaiXe = x.SoGhe;

                dtg_show.Rows.Add(stt++, x.ID, TenhangXe, LoaiXe, x.TenXe, x.BienSo, x.SoKhung, x.SoMay, x.DonGia, x.MauSac, x.TrangThaiDangKiem, x.TrangThaiBaoHiem, trangThaiAsString);
            }
        }

        private void cb_seachhx_TextChanged(object sender, EventArgs e)
        {
            string hangxe = cb_seachhx.Text;
            var filterhx = _xe.GetAll().Where(x => x.TenHangXe.Contains(hangxe));
            dtg_show.Rows.Clear();
            int stt = 1;
            foreach (var x in filterhx)
            {
                string trangThaiAsString = GetTrangThaiAsString(x.TrangThai);
                string TenhangXe = x.TenHangXe;
                int LoaiXe = x.SoGhe;

                dtg_show.Rows.Add(stt++, x.ID, TenhangXe, LoaiXe, x.TenXe, x.BienSo, x.SoKhung, x.SoMay, x.DonGia, x.MauSac, x.TrangThaiDangKiem, x.TrangThaiBaoHiem, trangThaiAsString);
            }
        }

        private void cb_seachms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QuanLiXeView_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bt_lbh_Click(object sender, EventArgs e)
        {
            var bhiem = new BaoHiemView();
            bhiem.ShowDialog();
        }

        private void cb_seachhx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_seachhx_TextChanged_1(object sender, EventArgs e)
        {
            string hangxe = cb_seachhx.Text;
            var filterhx = _xe.GetAll().Where(x => x.TenHangXe.Contains(hangxe));
            dtg_show.Rows.Clear();
            int stt = 1;
            foreach (var x in filterhx)
            {
                string trangThaiAsString = GetTrangThaiAsString(x.TrangThai);
                string TenhangXe = x.TenHangXe;
                int LoaiXe = x.SoGhe;

                dtg_show.Rows.Add(stt++, x.ID, TenhangXe, LoaiXe, x.TenXe, x.BienSo, x.SoKhung, x.SoMay, x.DonGia, x.MauSac, x.TrangThaiDangKiem, x.TrangThaiBaoHiem, trangThaiAsString);
            }
        }
    }
}
