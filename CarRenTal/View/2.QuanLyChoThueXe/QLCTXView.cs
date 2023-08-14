using Bus.Serviece.Implements;
using CarRenTal.View._2.QuanLyChoThueXe;
using Dal.Modal;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRenTal.View.QuanLyChoThueXe
{
    public partial class QLCTXView : Form
    {
        int trangThai = 1;
        HoaDonChiTietService hdService = new HoaDonChiTietService();
        List<HoaDonChiTiet> _lstHDCT;
        KhachHang kh;
        HoaDonChiTiet hoaDonCT;
        HoaDonService hoaDonService = new HoaDonService();
        public QLCTXView()
        {
            InitializeComponent();
        }
        public QLCTXView(NhanVien nhanVien)
        {
            InitializeComponent();
            gr_chucVu.Text = nhanVien.ChucVu.TenChucVu.ToString();
            lb_name.Text = nhanVien.HoTen;

        }


        private void QLCTXView_Load(object sender, EventArgs e)
        {
            cbb_loaiGiayTo.DataSource = hdService.GetGiayTo();
            cbb_loaiGiayTo.DisplayMember = "loaiGiayTo";
            cbb_loaiGiayTo.ValueMember = "Id";
            cbb_loaiTaiSan.DataSource = hdService.GetTaiSan();
            cbb_loaiTaiSan.DisplayMember = "loaiTaiSan";
            cbb_loaiTaiSan.ValueMember = "Id";
            bt_nhanXe_Click(null, null);
        }

        private void bt_nhanXe_Click(object sender, EventArgs e)
        {
            SetBackGround();
            bt_nhanXe.BackColor = Color.LightGray;
            trangThai = 1;
            LoadData(trangThai, null);
        }

        private void bt_dangThue_Click(object sender, EventArgs e)
        {
            SetBackGround();
            bt_dangThue.BackColor = Color.LightGray;
            trangThai = 2;
            LoadData(trangThai, null);
        }

        private void bt_denNgay_Click(object sender, EventArgs e)
        {
            SetBackGround();
            bt_denNgay.BackColor = Color.LightGray;
            trangThai = 3;
            LoadData(trangThai, null);
        }
        private void SetBackGround()
        {
            hoaDonCT = null;
            bt_dangThue.BackColor = SystemColors.Window;
            bt_denNgay.BackColor = SystemColors.Window;
            bt_nhanXe.BackColor = SystemColors.Window;
        }
        private void LoadData(int tThai, string timKiem)
        {

            dtgv_data.Rows.Clear();
            dtgv_data.ColumnCount = 9;
            dtgv_data.Columns[0].HeaderText = "ID";
            dtgv_data.Columns[0].Visible = false;
            dtgv_data.Columns[1].HeaderText = "Tên xe";
            dtgv_data.Columns[2].HeaderText = "Biển số";
            dtgv_data.Columns[3].HeaderText = "Tên khách hàng";
            dtgv_data.Columns[4].HeaderText = "Ngày nhận xe";
            dtgv_data.Columns[5].HeaderText = "Ngày trả xe";
            dtgv_data.Columns[6].HeaderText = "Tiền cọc";
            dtgv_data.Columns[7].HeaderText = "Tổng tiền";
            dtgv_data.Columns[8].HeaderText = "Trạng thái";
            _lstHDCT = hdService.GetHDCT(tThai, timKiem);
            if (_lstHDCT != null)
            {
                int stt = 0;
                foreach (var item in _lstHDCT)
                {
                    string tThai2 = CheckTrangThai(item.TrangThai, item.NgayBatDau, item.NgayKetThuc, tThai);
                    dtgv_data.Rows.Add(item.Id, item.Xe.LoaiXe.Name, item.Xe.BienSo, item.HoaDonThueXe.KhachHang.Name, item.NgayBatDau.Date, item.NgayKetThuc.Date, item.TienCoc, item.TongTien, tThai2);
                    if (tThai2 == "Quá hạn nhận xe" || tThai2 == "Quá hạn trả xe")
                    {
                        dtgv_data.Rows[stt].DefaultCellStyle.BackColor = Color.OrangeRed;
                    }
                    stt++;
                }
            }
            bt_cancels_Click(null, null);
        }

        private string CheckTrangThai(int trangThai, DateTime dateNhan, DateTime dateTra, int tThai)
        {
            if (tThai == 1)
            {
                if (DateTime.Now.Date == dateNhan.Date)
                {
                    return "Đến ngày nhận";
                }
                return "Quá hạn nhận xe";
            }
            else if (tThai == 3)
            {
                if (DateTime.Now.Date == dateTra.Date)
                {
                    return "Đến ngày trả";
                }
                return "Quá hạn trả xe";
            }
            return "Đang cho thuê";
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            LoadData(trangThai, tx_search.Text);
        }

        private void dtgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tx_chiTiet.Text = "";
            tx_giaTri.Text = "";
            tx_phuPhi.Text = "";
            cbb_loaiGiayTo.SelectedIndex = -1;
            cbb_loaiTaiSan.SelectedIndex = -1;
            hoaDonCT = _lstHDCT.FirstOrDefault(p => p.Id == Guid.Parse(dtgv_data.CurrentRow.Cells[0].Value.ToString()));
            if (hoaDonCT != null)
            {
                tx_tenKhach.Text = hoaDonCT.HoaDonThueXe.KhachHang.Name;
                tx_sdt.Text = hoaDonCT.HoaDonThueXe.KhachHang.SDT;
                cbb_trangThai.SelectedIndex = hoaDonCT.TrangThai;
                if (hoaDonCT.theChaps.Count > 0&& hoaDonCT.TrangThai!=1)
                {
                    cbb_loaiGiayTo.SelectedValue = hoaDonCT.theChaps.ToList()[0].IdGiayTo;
                    cbb_loaiTaiSan.SelectedValue = hoaDonCT.theChaps.ToList()[0].IdTS;
                    tx_giaTri.Text = hoaDonCT.theChaps.ToList()[0].GiaTri.ToString();
                    tx_chiTiet.Text = hoaDonCT.theChaps.ToList()[0].MoTa;
                    if (hoaDonCT.chiPhiPhatSinhs != null)
                    {
                        decimal sum = 0;
                        foreach (var item in hoaDonCT.chiPhiPhatSinhs)
                        {
                            sum += item.GiaTien;
                        }
                        tx_phuPhi.Text = sum.ToString();
                    }
                }
            }
        }

        private void bt_continue_Click(object sender, EventArgs e)
        {
            if (hoaDonCT == null)
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn chi tiết nào");
                return;
            }
            if (hoaDonCT.TrangThai == 1)
            {
                if (cbb_trangThai.SelectedIndex == 1)
                {
                    return;
                }
                if (cbb_trangThai.SelectedIndex == 3)
                {
                    MessageBox.Show("Không thể hoàn thành khi khách chưa lấy xe");
                    return;
                }
                if (DateTime.Now.Date > hoaDonCT.NgayBatDau.Date)
                {
                    if (cbb_trangThai.SelectedIndex != 4)
                    {
                        MessageBox.Show("Chỉ có thế chuyển trạng thái về khách không đến lấy xe");
                        return;

                    }
                    if (cbb_trangThai.SelectedIndex == 4)
                    {
                        hoaDonCT.TrangThai = 4;
                        hdService.UpdateHDCT(hoaDonCT);
                        hoaDonService.CheckHoaDon(hoaDonCT.HoaDonThueXe);
                        MessageBox.Show("Thành công");

                    }
                    LoadData(trangThai, null);
                    return;
                }
                if (cbb_trangThai.SelectedIndex == 0 || cbb_trangThai.SelectedIndex == 5 || cbb_trangThai.SelectedIndex == 4)
                {
                    hoaDonCT.TrangThai = cbb_trangThai.SelectedIndex;
                    hdService.UpdateHDCT(hoaDonCT);
                    hoaDonService.CheckHoaDon(hoaDonCT.HoaDonThueXe);
                    LoadData(trangThai, null);
                    return;
                }
                if (CheckTheChap() != null)
                {
                    MessageBox.Show("" + CheckTheChap());
                    return;
                }

                if (cbb_trangThai.SelectedIndex == 2)
                {
                    TheChap theChap = new TheChap()
                    {
                        Id = Guid.NewGuid(),
                        GiaTri = decimal.Parse(tx_giaTri.Text),
                        IdGiayTo = Guid.Parse(cbb_loaiGiayTo.SelectedValue.ToString()),
                        IdTS = Guid.Parse(cbb_loaiTaiSan.SelectedValue.ToString()),
                        MoTa = tx_chiTiet.Text,
                        TinhTrang = 1,
                        IdHDCT = hoaDonCT.Id
                    };
                    hdService.CreateTheChap(theChap);
                    hoaDonCT.TrangThai = 2;
                    hdService.UpdateHDCT(hoaDonCT);
                    hoaDonService.CheckHoaDon(hoaDonCT.HoaDonThueXe);
                    MessageBox.Show("Thành công");
                    LoadData(trangThai, null);
                    return;
                }

            }
            else if (dtgv_data.CurrentRow.Cells[8].Value.ToString() == "Đang cho thuê")
            {
                if (cbb_trangThai.SelectedIndex == 2) return;
                if (cbb_trangThai.SelectedIndex == 0 || cbb_trangThai.SelectedIndex == 3)
                {
                    hoaDonCT.TrangThai = cbb_trangThai.SelectedIndex;
                    hdService.UpdateHDCT(hoaDonCT);
                    if (cbb_trangThai.SelectedIndex == 3)
                    {
                        hdService.UpdateTheChap(new TheChap() { Id = hoaDonCT.Id });
                    }
                }
                else
                {
                    MessageBox.Show("Chỉ có thế chuyển trạng thái thành hủy hoặc hoàn thành");
                }

            }
            else if (dtgv_data.CurrentRow.Cells[8].Value.ToString() == "Đến ngày trả" || dtgv_data.CurrentRow.Cells[8].Value.ToString() == "Quá hạn trả xe")
            {
                if (cbb_trangThai.SelectedIndex != 0 && cbb_trangThai.SelectedIndex != 3)
                {
                    MessageBox.Show("Chỉ có thế chuyển trạng thái thành hủy hoặc hoàn thành");
                    return;
                }
                else
                {
                    hoaDonCT.TrangThai = cbb_trangThai.SelectedIndex;
                    TheChap theChap1 = new TheChap() { Id= hoaDonCT.Id,TinhTrang=2};
                    hdService.UpdateTheChap(theChap1);
                    hdService.UpdateHDCT(hoaDonCT);
                }
            }
            hdService.UpdateData();
            LoadData(trangThai, null);
        }

        private string CheckTheChap()
        {
            if (cbb_loaiGiayTo.SelectedIndex == -1)
            {
                return "Chưa chọn loại giấy tờ thế chấp";
            }
            if (cbb_loaiTaiSan.SelectedIndex == -1)
            {
                return "Chưa chọn loại tài sản thế chấp";
            }
            if (tx_chiTiet.Text.Length < 1)
            {
                return "Chưa nhập chi tiết thế chấp";
            }
            return null;
        }

        private void bt_cancels_Click(object sender, EventArgs e)
        {
            cbb_loaiTaiSan.SelectedIndex = -1;
            cbb_loaiGiayTo.SelectedIndex = -1;
            tx_chiTiet.Text = "";
            tx_giaTri.Text = "";
            tx_sdt.Text = "";
            // tx_search.Text = "";
            tx_tenKhach.Text = "";
            tx_thanhToan.Text = "0";
            tx_phuPhi.Text = "0";
            cbb_trangThai.SelectedIndex = -1;
            hoaDonCT = null;
        }

        private void cbb_trangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hoaDonCT == null)
            {
                return;
            }
            if (hoaDonCT.TrangThai == 1)
            {
                if (cbb_trangThai.SelectedIndex == 2)
                {
                    tx_giaTri.Text = (hoaDonCT.DonGia * 30).ToString();
                    tx_thanhToan.Text = (hoaDonCT.TongTien - hoaDonCT.TienCoc).ToString();
                    return;
                }
                if (cbb_trangThai.SelectedIndex == 5)
                {
                    tx_thanhToan.Text = (-hoaDonCT.TienCoc * 2).ToString();
                    return;
                }
                if (cbb_trangThai.SelectedIndex != 1)
                {
                    tx_giaTri.Text = "";
                    tx_thanhToan.Text = 0.ToString();
                }
            }
            else if (hoaDonCT.TrangThai == 2)
            {
                if (cbb_trangThai.SelectedIndex == 3)
                {
                    tx_thanhToan.Text = tx_phuPhi.Text;
                }
                else
                {
                    tx_thanhToan.Text = 0.ToString();
                }
            }
        }

        private void bt_chiTiet_Click(object sender, EventArgs e)
        {
            if (hoaDonCT == null)
            {
                return;
            }
            using (ThongTinKhach form = new ThongTinKhach(hoaDonCT.HoaDonThueXe.KhachHang))
            {
                form.ShowDialog();
            }
        }

        private void bt_addPP_Click(object sender, EventArgs e)
        {
            if (hoaDonCT != null)
            {
                using (PhuPhi form = new PhuPhi(hoaDonCT))
                {
                    form.ShowDialog();
                }
                LoadData(trangThai, null);
            }
        }
    }
}
