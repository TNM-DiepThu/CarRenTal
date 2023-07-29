using Bus.Serviece.Implements;
using Bus.Serviece.Interface;
using CarRenTal.View.QuanLiXe;
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
        private Guid selectedXeId;
        public QuanLiXeView()
        {
            InitializeComponent();
            _xe = new XeServiece();
            _baoHiem = new XeBaoHiemServiece();
            _dangkiem = new DangKiemServiece();
            LoadData();
        }

        private void QuanLiXe_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private string GetTrangThaiAsString(int trangThai)
        {
            if (trangThai == 0)
            {
                return "đang hoạt động";

            }
            if (trangThai == 1)
            {
                return "ngừng hoạt động";
            }
            else
            {
                return "bị xoá";

            }

        }

        private void LoadData()
        {
            int stt = 1;
            dtg_show.ColumnCount = 13;
            dtg_show.Columns[0].Name = "STT";
            dtg_show.Columns[1].Name = "Id";
            dtg_show.Columns[1].Visible = false;
            dtg_show.Columns[2].Name = "Hãng Xe";
            dtg_show.Columns[3].Name = "Tên xe";
            dtg_show.Columns[5].Name = "Biển Số";
            dtg_show.Columns[6].Name = "Số khung";
            dtg_show.Columns[7].Name = "Số Máy";
            dtg_show.Columns[8].Name = "Đơn giá";
            dtg_show.Columns[9].Name = "Màu sắc";
            dtg_show.Columns[10].Name = "Trạng thái đăng kiếm";
            dtg_show.Columns[11].Name = "Trạng thái bảo hiểm";
            dtg_show.Columns[12].Name = "Trạng Thái";
            dtg_show.Rows.Clear();
            foreach (var x in _xe.GetAll())
            {
                string trangThaiAsString = GetTrangThaiAsString(x.TrangThai);
                string TenhangXe = x.TenHangXe;
                int LoaiXe = x.SoGhe;



                dtg_show.Rows.Add(stt++, x.ID, TenhangXe, LoaiXe, x.TenXe, x.BienSo, x.SoKhung, x.SoMay, x.DonGia, x.MauSac, x.TrangThaiDangKiem, x.TrangThaiBaoHiem, trangThaiAsString);
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
    }
}
