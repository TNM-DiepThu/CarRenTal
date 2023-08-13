using Bus.Serviece.Implements;
using CarRenTal.View._4.QuanLyHoaDon;
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

namespace CarRenTal.View._4._QuanLyHoaDon
{
    public partial class QLHDDView : Form
    {

        List<HoaDonThueXe> lstHoaDon;
        QLHDService service = new QLHDService();
        public QLHDDView()
        {
            InitializeComponent();
        }

        private void QLHDDView_Load(object sender, EventArgs e)
        {
            dtp_startDate.Value = DateTime.Now.AddDays(-15);
            dtp_endDate.Value = DateTime.Now.AddDays(15);
        }
        public void LoadData(DateTime start, DateTime end, string search)
        {
            dtgv_data.Rows.Clear();
            dtgv_data.ColumnCount = 8;
            dtgv_data.Columns[0].HeaderText = "ID";
            dtgv_data.Columns[0].Visible = false;
            dtgv_data.Columns[1].HeaderText = "Số hợp đồng";
            dtgv_data.Columns[2].HeaderText = "Tên khách hàng";
            dtgv_data.Columns[3].HeaderText = "Nhân viên tạo";
            dtgv_data.Columns[4].HeaderText = "Ngày tạo hóa đơn";
            dtgv_data.Columns[5].HeaderText = "Trạng thái";
            dtgv_data.Columns[6].HeaderText = "Tổng tiền dự tính";
            dtgv_data.Columns[7].HeaderText = "Tổng tiền đã thu";
            lstHoaDon = service.GetData(start, end, search);
            foreach (var item in lstHoaDon)
            {
                decimal sum = item.HoaDonChiTiets.Sum(x => x.TongTien);
                decimal sumTT = service.TinhTien(item);
                string trangThai = GetTrangThai(item.TrangThai);
                dtgv_data.Rows.Add(item.Id, item.SoHopDong, item.KhachHang.Name, item.NhanVien.HoTen, item.NgayTao, trangThai, sum, sumTT);
            }
        }

        private string GetTrangThai(int trangThai)
        {
            switch (trangThai)
            {
                case 0:
                    return "Đã hủy";
                case 1:
                    return "Đang thực hiện";
                case 2:
                    return "Thực hiện 1 phần";
                case 3:
                    return "Hoàn thành 1 phần";
                case 4:
                    return "Hoàn thành";
            }
            return null;
        }

        private void dtp_startDate_ValueChanged(object sender, EventArgs e)
        {
            LoadData(dtp_startDate.Value.Date, dtp_endDate.Value.Date, "");
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            LoadData(dtp_startDate.Value.Date, dtp_endDate.Value.Date, tx_search.Text);
        }

        private void dtgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tx_ten.Text = dtgv_data.CurrentRow.Cells[2].Value.ToString();
            tx_canCuoc.Text = dtgv_data.CurrentRow.Cells[3].Value.ToString();
            tx_nguoiTao.Text = dtgv_data.CurrentRow.Cells[4].Value.ToString();
            tx_soHopDong.Text = dtgv_data.CurrentRow.Cells[1].Value.ToString();
            lb_id.Text = dtgv_data.CurrentRow.Cells[0].Value.ToString();
        }

        private void bt_chiTiet_Click(object sender, EventArgs e)
        {
            HoaDonThueXe hoaDon = lstHoaDon.FirstOrDefault(p => p.Id == Guid.Parse(lb_id.Text));
            using (HoaDonDaCoc form = new HoaDonDaCoc(hoaDon))
            {
                form.ShowDialog();
                lstHoaDon.FirstOrDefault(p => p.Id == form.hoaDon.Id).TrangThai = form.hoaDon.TrangThai;
            };


            LoadData(dtp_startDate.Value.Date, dtp_endDate.Value.Date, "");
        }
    }
}
