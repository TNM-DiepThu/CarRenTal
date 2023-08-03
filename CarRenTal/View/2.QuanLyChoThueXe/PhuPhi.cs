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

namespace CarRenTal.View._2.QuanLyChoThueXe
{
    public partial class PhuPhi : Form
    {
        HoaDonChiTietService hdService = new HoaDonChiTietService();
        public bool addPhuPhi;
        HoaDonChiTiet _hdct;
        public PhuPhi()
        {
            InitializeComponent();

            cbb_loaiPP.DataSource = hdService.GetLoaiPhuPhi();
            cbb_loaiPP.DisplayMember = "TenLoaiPhuPhi";
            cbb_loaiPP.ValueMember = "Id";
        }
        public PhuPhi(HoaDonChiTiet hdct)
        {
            InitializeComponent();
            lb_khach.Text = "Tên khách hàng: " + hdct.HoaDonThueXe.KhachHang.Name;
            lb_xe.Text = "Tên xe: " + hdct.Xe.LoaiXe.Name;
            lb_bienSo.Text = "Biển số xe: " + hdct.Xe.BienSo;
            cbb_loaiPP.DataSource = hdService.GetLoaiPhuPhi();
            cbb_loaiPP.DisplayMember = "TenLoaiPhuPhi";
            cbb_loaiPP.ValueMember = "Id";
            _hdct = hdct;
        }

        private void PhuPhi_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dtgv_data.Rows.Clear();
            dtgv_data.ColumnCount = 4;
            dtgv_data.Columns[0].HeaderText = "ID phụ phí";
            dtgv_data.Columns[0].Visible = false;
            dtgv_data.Columns[1].HeaderText = "Tên phụ phí phụ phí";
            dtgv_data.Columns[2].HeaderText = "Giá trị";
            dtgv_data.Columns[3].HeaderText = "Mô tả";
            if (_hdct.chiPhiPhatSinhs.Count!=0)
            {
                foreach (var item in _hdct.chiPhiPhatSinhs)
                {
                    dtgv_data.Rows.Add(item.LoaiPhuPhi.Id, item.LoaiPhuPhi.TenLoaiPhuPhi, item.GiaTien, item.MoTa);
                }
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (!CheckPhuPhi())
            {
                MessageBox.Show("Thêm phụ phí không hợp lệ");
                return;
            }
            dtgv_data.Rows.Add(cbb_loaiPP.SelectedValue.ToString(), cbb_loaiPP.Text, decimal.Parse(tx_giaTri.Text), tx_moTa.Text);

        }
        private bool CheckPhuPhi()
        {
            try
            {
                decimal m = decimal.Parse(tx_giaTri.Text);
            }
            catch (Exception)
            {

                return false;
            }
            if (cbb_loaiPP.SelectedIndex == -1 || tx_giaTri.Text == "" || tx_moTa.Text == "")
            {
                return false;
            }
            return true;
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            if (dtgv_data.CurrentRow == null)
            {
                MessageBox.Show("Chọn phụ phí cần xóa");
                return;
            }
            dtgv_data.Rows.Remove(dtgv_data.CurrentRow);
        }

        private void dtgv_data_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TinhTien();
        }

        private void dtgv_data_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TinhTien();
        }
        private void TinhTien()
        {
            if (dtgv_data.RowCount > 0)
            {
                decimal tong = 0;
                for (int i = 0; i < dtgv_data.Rows.Count; i++)
                {
                    tong += decimal.Parse(dtgv_data.Rows[i].Cells[2].Value.ToString());
                }
                tx_tongTien.Text = tong.ToString();
            }
            else
            {
                tx_tongTien.Text = 0.ToString();
            }
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn không?","Xác nhận",MessageBoxButtons.YesNo)==DialogResult.No)
            {
                return;
            }
            if (_hdct.chiPhiPhatSinhs.Count>0)
            {
                hdService.RemoveChiPhi(_hdct.chiPhiPhatSinhs.ToList()[0]);
            }
            if (dtgv_data.RowCount!=0)
            {
                for (int i = 0; i < dtgv_data.RowCount; i++)
                {
                    ChiPhiPhatSinh phuPhi = new ChiPhiPhatSinh()
                    {
                        Id = Guid.NewGuid(),
                        GiaTien = decimal.Parse(dtgv_data.Rows[i].Cells[2].Value.ToString()),
                        IdHDCT = _hdct.Id,
                        MoTa = dtgv_data.Rows[i].Cells[3].Value.ToString(),
                        IdLPP = Guid.Parse(dtgv_data.Rows[i].Cells[0].Value.ToString())
                    };
                    hdService.CreatePhuPhi(phuPhi);
                }
            }
               this.Close();
        }
    }
}
