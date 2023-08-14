using Bus.Serviece.Implements;
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

namespace CarRenTal.View._4.QuanLyHoaDon
{
    public partial class HoaDonDaCoc : Form
    {
        public HoaDonThueXe hoaDon;
        List<HoaDonChiTiet> lsthdct;
        ChoThueXeService service = new ChoThueXeService();
        HoaDonChiTiet hdct;
        HoaDonService hoaDonService = new HoaDonService();
        public HoaDonDaCoc(HoaDonThueXe hd)
        {

            InitializeComponent();
            hoaDon = hd;
            lsthdct = hd.HoaDonChiTiets.ToList();
            cbb_giayTo.DataSource = service.GetGiayTo();
            cbb_giayTo.DisplayMember = "LoaiGiayTo";
            cbb_giayTo.ValueMember = "Id";
            cbb_giayTo.SelectedIndex = -1;
            cbb_taiSan.DataSource = service.GetTaiSan();
            cbb_taiSan.DisplayMember = "LoaiTaiSan";
            cbb_taiSan.ValueMember = "Id";
            cbb_taiSan.SelectedIndex = -1;
        }

        private void HoaDonDaCoc_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void LoadData()
        {
            dtgv_data.Rows.Clear();
            dtgv_data.ColumnCount = 8;
            dtgv_data.Columns[0].HeaderText = "ID";
            dtgv_data.Columns[1].HeaderText = "Tên xe";
            dtgv_data.Columns[2].HeaderText = "Biển số";
            dtgv_data.Columns[3].HeaderText = "Ngày thuê";
            dtgv_data.Columns[4].HeaderText = "Ngày trả";
            dtgv_data.Columns[5].HeaderText = "Tổng tiền";
            dtgv_data.Columns[6].HeaderText = "Tiền cọc";
            dtgv_data.Columns[7].HeaderText = "Trạng thái";
            foreach (var item in lsthdct)
            {
                dtgv_data.Rows.Add(item.Id, item.Xe.LoaiXe.Name, item.Xe.BienSo, item.NgayBatDau, item.NgayKetThuc, item.TongTien, item.TienCoc, GetTrangThai(item.TrangThai));
            }


        }
        public string GetTrangThai(int trangThai)
        {
            switch (trangThai)
            {
                case 0:
                    return "Đã hủy";
                case 1:
                    return "Đặt cọc";
                case 2:
                    return "Đang thuê";
                case 3:
                    return "Đã hoàn thành";
                case 4:
                    return "Không lấy xe";
                case 5:
                    return " Bồi thường cọc";
            }
            return null;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbb_giayTo.SelectedIndex = -1;
            cbb_taiSan.SelectedIndex = -1;
            tx_soTien.Text = "";
            tx_chiTiet.Text = "";
            dtgv_data.Columns[0].HeaderText = "ID";
            dtgv_data.Columns[1].HeaderText = "Tên xe";
            dtgv_data.Columns[2].HeaderText = "Biển số";
            dtgv_data.Columns[3].HeaderText = "Ngày thuê";
            dtgv_data.Columns[4].HeaderText = "Ngày trả";
            dtgv_data.Columns[5].HeaderText = "Tổng tiền";
            dtgv_data.Columns[6].HeaderText = "Tiền cọc";
            dtgv_data.Columns[7].HeaderText = "Trạng thái";
            lb_id.Text = dtgv_data.CurrentRow.Cells[0].Value.ToString();
            hdct = lsthdct.FirstOrDefault(p => p.Id == Guid.Parse(lb_id.Text));
            tx_bienSo.Text = hdct.Xe.BienSo;
            tx_LoaiXe.Text = hdct.Xe.LoaiXe.Name;
            tx_ngayThue.Text = hdct.NgayBatDau.ToString();
            tx_ngayTra.Text = hdct.NgayKetThuc.ToString();
            tx_tienCoc.Text = hdct.TienCoc.ToString();
            cbb_trangThai.SelectedIndex = hdct.TrangThai;
            if (hdct.theChaps.ToList().Count != 0)
            {
                cbb_giayTo.SelectedValue = hdct.theChaps.ToList()[0].IdGiayTo;
                cbb_taiSan.SelectedValue = hdct.theChaps.ToList()[0].IdTS;
                tx_soTien.Text = (hdct.DonGia * 30).ToString();
                tx_chiTiet.Text = hdct.theChaps.ToList()[0].MoTa.ToString();
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {

            if (checkSave() != null)
            {
                MessageBox.Show("" + checkSave());
                return;
            }
            hdct.TrangThai = cbb_trangThai.SelectedIndex;
            hoaDonService.UpdateHoaDon(hdct);

            if (cbb_trangThai.SelectedIndex == 2 || cbb_trangThai.SelectedIndex == 3)
            {
                TheChap theChap = new TheChap()
                {
                    Id = hdct.theChaps.ToList()[0].Id,
                    IdGiayTo = Guid.Parse(cbb_giayTo.SelectedValue.ToString()),
                    IdTS = Guid.Parse(cbb_taiSan.SelectedValue.ToString()),
                    IdHDCT = hdct.Id,
                    MoTa = tx_chiTiet.Text,
                    TinhTrang = (cbb_trangThai.SelectedIndex == 3 ? 2 : 1),
                };
                hoaDonService.UpdateTheChap(theChap);
            }
            hoaDon.TrangThai = hoaDonService.CheckHoaDon(hoaDon);
            MessageBox.Show("Thành công");
        }
        private string checkSave()
        {
            if (hdct == null)
            {
                return " Bạn chưa chọn hóa đơn chi tiết nào";
            }
            if (hdct.NgayBatDau.Date < DateTime.Now.Date && cbb_trangThai.SelectedIndex == 1)
            {
                return " Không thể chuyển trạng thái vì qua ngày bắt đầu";
            }
            if ((cbb_trangThai.SelectedIndex == 2 || cbb_trangThai.SelectedIndex == 3))
            {
                if (cbb_taiSan.SelectedIndex < 0 || cbb_giayTo.SelectedIndex < 0 || tx_chiTiet.Text.Length < 1 || tx_soTien.Text.Length < 1)
                {
                    return "Kiểm tra thông tin thế chấp";
                }
            }

            return null;
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbb_trangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_trangThai.SelectedIndex == 2 && hdct != null)
            {
                decimal theChap = hdct.DonGia * (decimal)30.0;
                tx_soTien.Text = theChap.ToString();
            }
        }
    }



}

