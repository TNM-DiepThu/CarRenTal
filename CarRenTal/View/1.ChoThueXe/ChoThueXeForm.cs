using Bus.Serviece.Implements;
using Dal.Modal;
using Dal.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRenTal.View._1.ChoThueXe
{
    public partial class ChoThueXeForm : Form
    {
        DateTime maxDate = DateTime.Now.AddDays(45);
        ChoThueXeService service = new ChoThueXeService();
        public List<HoaDonChiTiet> lstXeChon = new List<HoaDonChiTiet>();
        NhanVien nhanVienLogin;
        decimal heSo = 2 / 10;
        decimal minTC = 0;
        //khai báo để test
        public List<Xe> lstXeTest;
        public string maXe3;
        public int CountXeTest5;
        public KhachHang khtest6;
        public bool checkTest6= false;
        public bool checkTest7= false;
        public bool checkTest10= false;
        public bool dkTest7= false;
        public int countXe6= 0;

		public ChoThueXeForm(NhanVien nhanVien)
        {
            InitializeComponent();

            nhanVienLogin = nhanVien;          
		}

        public ChoThueXeForm()
        {
        }

        public void LoadKhachHang(KhachHang khachHang)
        {
            if (khachHang == null) { return; }
            tx_nameKhach.Text = khachHang.Name;
            tx_canCuoc.Text = khachHang.CCCD;
            lb_idKhach.Text = khachHang.Id.ToString();
            khtest6 = khachHang;
        }

        public void ChoThueXeForm_Load(object sender, EventArgs e)
        {
            LoadData();
            bt_search_Click(null, null);
        }
        public void LoadData()
        {
            dtgv_xeSS.Rows.Clear();
            dtgv_xeChon.Rows.Clear();
            dtgv_xeSS.ColumnCount = 8;
            dtgv_xeSS.Columns[0].HeaderText = "Tên xe";
            dtgv_xeSS.Columns[1].HeaderText = "Biển số";
            dtgv_xeSS.Columns[2].HeaderText = "Màu sắc";
            dtgv_xeSS.Columns[3].HeaderText = "Đơn giá";
            dtgv_xeSS.Columns[4].HeaderText = "Loại số xe";
            dtgv_xeSS.Columns[5].HeaderText = "Loại nhiên liệu";
            dtgv_xeSS.Columns[6].HeaderText = "Số ghế";
            dtgv_xeSS.Columns[7].HeaderText = "ID";
           // dtgv_xeSS.Columns[7].Visible = false;
            dtgv_xeChon.ColumnCount = 9;
            dtgv_xeChon.Columns[0].HeaderText = "Tên xe";
            dtgv_xeChon.Columns[1].HeaderText = "Biển số";
            dtgv_xeChon.Columns[2].HeaderText = "Màu sắc";
            dtgv_xeChon.Columns[3].HeaderText = "Đơn giá";
            dtgv_xeChon.Columns[4].HeaderText = "Ngày bắt đầu";
            dtgv_xeChon.Columns[5].HeaderText = "Ngày kết thúc";
            dtgv_xeChon.Columns[6].HeaderText = "Số ngày";
            dtgv_xeChon.Columns[7].HeaderText = "Thành tiền";
            dtgv_xeChon.Columns[8].HeaderText = "ID";
            dtgv_xeChon.Columns[8].Visible = false;

            dtp_ngayThue.MinDate = DateTime.Now;
            dtp_ngayThue.MaxDate = maxDate;
            dtp_ngayTra.MaxDate = maxDate;
            dtp_ngayTra.MinDate = DateTime.Now;
            dtp_ngayTra.Value = maxDate;
            tx_maHopDong.Text = service.CreateSoHopDong().ToString();
            cbb_hangXe.DataSource = service.GetHangXe();
            cbb_hangXe.DisplayMember = "Name";
            cbb_hangXe.ValueMember = "Id";

            cbb_typeGiayTo.DataSource = service.GetGiayTo();
            cbb_typeGiayTo.DisplayMember = "LoaiGiayTo";
            cbb_typeGiayTo.ValueMember = "Id";

            cbb_taiSan.DataSource = service.GetTaiSan();
            cbb_taiSan.DisplayMember = "LoaiTaiSan";
            cbb_taiSan.ValueMember = "Id";
            cbb_nhienLieu.SelectedIndex = 0;
            cbb_soGhe.SelectedIndex = 0;
            cbb_hopSo.SelectedIndex = 0;
            cbb_hangXe.SelectedIndex = 0;
            cbb_typeGiayTo.SelectedIndex = -1;
            cbb_taiSan.SelectedIndex = -1;
            cbb_trangThai.SelectedIndex = 0;
        }

        public void bt_chooseCurtomer_Click(object sender, EventArgs e)
        {
            using (ChonKhachHangForm chonKhach = new ChonKhachHangForm())
            {
                if (chonKhach.ShowDialog() == DialogResult.OK)
                {
                    LoadKhachHang(chonKhach.khachHangChon);
                }
            };
        }


        public void bt_add_Click(object sender, EventArgs e)
        {
            if (dtgv_xeSS.CurrentRow == null)
            {
                return;
            }
            TimeSpan interval = dtp_ngayTra.Value.AddDays(1).Date.Subtract(dtp_ngayThue.Value.Date);
            if (interval.Days < 0)
            {
                return;
            }
            if (interval.Days == 0)
            {
                interval = DateTime.Now.AddDays(2).Subtract(DateTime.Now);
            }
            dtgv_xeChon.Rows.Add(dtgv_xeSS.CurrentRow.Cells[0].Value.ToString(),
                                 dtgv_xeSS.CurrentRow.Cells[1].Value.ToString(),
                                 dtgv_xeSS.CurrentRow.Cells[2].Value.ToString(),
                                 dtgv_xeSS.CurrentRow.Cells[3].Value.ToString(),
                                 dtp_ngayThue.Value.Date.ToString(),
                                 dtp_ngayTra.Value.Date.ToString(),
                                 interval.Days.ToString(),
                                 int.Parse(dtgv_xeSS.CurrentRow.Cells[3].Value.ToString()) * interval.Days,
                                  dtgv_xeSS.CurrentRow.Cells[7].Value.ToString()
                                 );
            maXe3 = dtgv_xeChon[8,0].Value.ToString();
           
           
        }


        void checkDate()
        {

        }
        public void dtp_ngayThue_ValueChanged(object sender, EventArgs e)
        {
            bt_search_Click(null, null);
            checkDate();
        }

        public void dtp_ngayTra_ValueChanged(object sender, EventArgs e)
        {
            bt_search_Click(null, null);
            checkDate();
        }

        public void cbb_trangThai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbb_trangThai.SelectedIndex == 1)
            {
                heSo = 1;
                gb_layXe.Visible = true;
            }
            else
            {
                heSo = 2 / 10;
                gb_layXe.Visible = false;
            }
            if (tx_phiThue.Text.Length > 3)
            {
                tx_phiThue_TextChanged(null, null);
            }
        }

        public void dt_delete_Click(object sender, EventArgs e)
        {
            if (dtgv_xeChon.CurrentRow == null)
            {
                return;
            }
			countXe6++;
			dtgv_xeChon.Rows.Remove(dtgv_xeChon.CurrentRow);
        }

        public void bt_deleteAll_Click(object sender, EventArgs e)
        {
            dtgv_xeChon.Rows.Clear();
            CountXeTest5 = dtgv_xeChon.RowCount;

        }

        public void bt_search_Click(object sender, EventArgs e)
        {
            dtgv_xeSS.Rows.Clear();
            List<Xe> lstXe = service.DataXe(dtp_ngayThue.Value.Date, dtp_ngayTra.Value.Date, lstXeChon);
            if (cbb_soGhe.SelectedIndex > 0 && lstXe != null)
            {
                lstXe = lstXe.Where(p => p.LoaiXe.SoGhe == int.Parse(cbb_soGhe.Text)).ToList();
            }
            if (cbb_hangXe.SelectedIndex > 0 && lstXe != null)
            {
                lstXe = lstXe.Where(p => p.LoaiXe.HangXe.Id == Guid.Parse(cbb_hangXe.SelectedValue.ToString())).ToList();
            }
            if (cbb_hopSo.SelectedIndex > 0 && lstXe != null)
            {
                lstXe = lstXe.Where(p => p.LoaiXe.LoaiSoXe == cbb_hopSo.Text).ToList();
            }
            if (cbb_nhienLieu.SelectedIndex > 0 && lstXe != null)
            {
                lstXe = lstXe.Where(p => p.LoaiXe.LoaiNguyenLieu == cbb_nhienLieu.Text).ToList();
            }
            if (lstXe == null || lstXe.Count == 0)
            {
                dtgv_xeSS.Rows.Clear();
                return;
            }
            lstXe = lstXe.Where(p => p.DonGia > nud_minGia.Value && p.DonGia < nud_maxGia.Value).ToList();
            if (tx_search.Text != null)
            {
                lstXe = lstXe.Where(p => p.LoaiXe.Name.ToLower().Contains(tx_search.Text.ToLower())|| p.LoaiXe.HangXe.Name.ToLower().Contains(tx_search.Text.ToLower())).ToList();
            }
            lstXeTest = lstXe;

			foreach (var item in lstXe)
            {
                dtgv_xeSS.Rows.Add(item.LoaiXe.HangXe.Name + " " + item.LoaiXe.Name, item.BienSo, item.MauSac.TenMauSac, item.DonGia, item.LoaiXe.LoaiSoXe, item.LoaiXe.LoaiNguyenLieu, item.LoaiXe.SoGhe, item.ID);
            }

        }

        public void CheckData()
        {
            lstXeChon = new List<HoaDonChiTiet>();
            minTC = 0;
            for (int i = 0; i < dtgv_xeChon.Rows.Count; i++)
            {
                lstXeChon.Add(new HoaDonChiTiet()
                {
                    IdXe = Guid.Parse(dtgv_xeChon.Rows[i].Cells[8].Value.ToString()),
                    NgayBatDau = DateTime.Parse(dtgv_xeChon.Rows[i].Cells[4].Value.ToString()),
                    NgayKetThuc = DateTime.Parse(dtgv_xeChon.Rows[i].Cells[5].Value.ToString()),
                    Id = Guid.NewGuid(),

                });
                minTC += decimal.Parse(dtgv_xeChon.Rows[i].Cells[3].Value.ToString()) * 36;
            }
            tx_giaTRi.Value = minTC;
            bt_search_Click(null, null);
            if (dtgv_xeChon.Rows.Count == 0)
            {
                tx_phiThue.Text = 0.ToString();
                tx_phiThanhToan.Text = 0.ToString();
                return;
            }
            decimal tongTien = 0;
            for (int i = 0; i < dtgv_xeChon.Rows.Count; i++)
            {

                tongTien += int.Parse(dtgv_xeChon.Rows[i].Cells[7].Value.ToString());
            }
            tx_phiThue.Text = tongTien.ToString();

        }

        public void dtgv_xeChon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CheckData();

        }

        public void dtgv_xeChon_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CheckData();
        }

        public void tx_phiThue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tx_coc.Text = (int.Parse(tx_phiThue.Text) * 0.2).ToString();
                if (heSo == 1)
                {
                    decimal sum = (decimal.Parse(tx_phiThue.Text) * heSo);
                    tx_phiThanhToan.Text = (sum).ToString();
                }
                else
                {
                    tx_phiThanhToan.Text = tx_coc.Text;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void bt_pay_Click(object sender, EventArgs e)
        {
            if (!CheckPay())
            {
                //  MessageBox.Show("Mời nhập đủ các trường!");
                checkTest6 = true;
                return;
            }
            if (!dkTest7)
            {
				if (MessageBox.Show("Bạn có xác nhận không?", "Xác nhận tạo hóa đơn", MessageBoxButtons.YesNo) == DialogResult.No)
				{
					return;
				}
			}
            if (cbb_trangThai.SelectedIndex == 0)
            {
                HoaDonThueXe hd = new HoaDonThueXe()
                {
                    Id = Guid.NewGuid(),
                    IdKhachHang = Guid.Parse(lb_idKhach.Text),
                    IdNhanVien = nhanVienLogin.Id,
                    NgayTao = DateTime.Now,
                    TrangThai = 1,
                    SoHopDong = service.CreateSoHopDong(),
                };
                service.CreateHD(hd);
                for (int i = 0; i < dtgv_xeChon.Rows.Count; i++)
                {
                    HoaDonChiTiet hdct = new HoaDonChiTiet()
                    {
                        Id = Guid.NewGuid(),
                        IdXe = Guid.Parse(dtgv_xeChon.Rows[i].Cells[8].Value.ToString()),
                        DonGia = int.Parse(dtgv_xeChon.Rows[i].Cells[3].Value.ToString()),
                        IdHoaDon = hd.Id,
                        NgayBatDau = DateTime.Parse(dtgv_xeChon.Rows[i].Cells[4].Value.ToString()),
                        NgayKetThuc = DateTime.Parse(dtgv_xeChon.Rows[i].Cells[5].Value.ToString()),
                        TongTien = int.Parse(dtgv_xeChon.Rows[i].Cells[6].Value.ToString()) * int.Parse(dtgv_xeChon.Rows[i].Cells[3].Value.ToString()),
                        TienCoc = int.Parse(dtgv_xeChon.Rows[i].Cells[6].Value.ToString()) * int.Parse(dtgv_xeChon.Rows[i].Cells[3].Value.ToString()) * 2 / 10,
                        TrangThai = 1,

                    };
                    service.CreateHDCT(hdct);

                }
                checkTest7 = true;
                MessageBox.Show("Đặt cọc thành công");
                button4_Click(null, null);
            }
            if (cbb_trangThai.SelectedIndex == 1)
            {
                for (int i = 0; i < dtgv_xeChon.Rows.Count; i++)
                {
                    bool checkNgay = DateTime.Parse(dtgv_xeChon.Rows[i].Cells[4].Value.ToString()).Date != DateTime.Now.Date;
                    if (checkNgay)
                    {
                        MessageBox.Show("Không thể nhận xe khi có các xe đặt khác ngày hôm nay!");
                        cbb_trangThai.SelectedIndex = 0;
                        return;
                    }
                }
                HoaDonThueXe hd = new HoaDonThueXe()
                {
                    Id = Guid.NewGuid(),
                    IdKhachHang = Guid.Parse(lb_idKhach.Text),
                    IdNhanVien = nhanVienLogin.Id,
                    NgayTao = DateTime.Now,
                    TrangThai = 1,
                    SoHopDong = service.CreateSoHopDong(),
                };
                service.CreateHD(hd);
                for (int i = 0; i < dtgv_xeChon.Rows.Count; i++)
                {
                    HoaDonChiTiet hdct = new HoaDonChiTiet()
                    {
                        Id = Guid.NewGuid(),
                        IdXe = Guid.Parse(dtgv_xeChon.Rows[i].Cells[8].Value.ToString()),
                        DonGia = int.Parse(dtgv_xeChon.Rows[i].Cells[3].Value.ToString()),
                        IdHoaDon = hd.Id,
                        NgayBatDau = DateTime.Parse(dtgv_xeChon.Rows[i].Cells[4].Value.ToString()),
                        NgayKetThuc = DateTime.Parse(dtgv_xeChon.Rows[i].Cells[5].Value.ToString()),
                        TongTien = int.Parse(dtgv_xeChon.Rows[i].Cells[6].Value.ToString()) * int.Parse(dtgv_xeChon.Rows[i].Cells[3].Value.ToString()),
                        TienCoc = int.Parse(dtgv_xeChon.Rows[i].Cells[6].Value.ToString()) * int.Parse(dtgv_xeChon.Rows[i].Cells[3].Value.ToString()) * 2 / 10,
                        TrangThai = 2,

                    };
                    service.CreateHDCT(hdct);
                    TheChap theChap = new TheChap()
                    {
                        Id = Guid.NewGuid(),
                        IdHDCT = hdct.Id,
                        TinhTrang = 1,
                        IdGiayTo = Guid.Parse(cbb_typeGiayTo.SelectedValue.ToString()),
                        IdTS = Guid.Parse(cbb_taiSan.SelectedValue.ToString()),
                        GiaTri = int.Parse(dtgv_xeChon.Rows[i].Cells[3].Value.ToString()) * 30,
                        MoTa = tx_chiTiet.Text,

                    };
                    service.CreateTC(theChap);
                }
                MessageBox.Show("Bạn có thể lấy xe thành công");
                bt_search_Click(null, null);
            }
        }

        public bool CheckPay()
        {
            if (dtgv_xeChon.Rows.Count < 1)
            {
                return false;
            }
            if (cbb_trangThai.SelectedIndex == 1 && (cbb_typeGiayTo.SelectedIndex < 0 || cbb_taiSan.SelectedIndex < 0 || tx_chiTiet.Text.Length <1))
            {
                return false;
            }
            if (tx_nameKhach.Text.Length < 3 || tx_phiThue.Text.Length < 3)
            {
                checkTest10 = true;
                return false;
            }
            return true;
        }

        public void button4_Click(object sender, EventArgs e)
        {
            dtgv_xeChon.Rows.Clear();
            tx_search.Text = "";
            tx_nameKhach.Text = "";
            lb_idKhach.Text = "";
            tx_canCuoc.Text = "";
            tx_maHopDong.Text = "";
            tx_chiTiet.Text = "";
            tx_coc.Text = "0";
            tx_phiThanhToan.Text = "0";
            tx_phiThue.Text = "0";
            nud_maxGia.Value = 10000000;
            nud_minGia.Value = 0;
            LoadData();
            bt_search_Click(null, null);
        }

        public void nud_minGia_ValueChanged(object sender, EventArgs e)
        {
            bt_search_Click(null, null);
        }

        public void nud_maxGia_ValueChanged(object sender, EventArgs e)
        {
            bt_search_Click(null, null);
        }

        public void cbb_soGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_search_Click(null, null);
        }
    }
}
