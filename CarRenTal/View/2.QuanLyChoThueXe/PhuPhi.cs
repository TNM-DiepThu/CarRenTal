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
        public PhuPhi()
        {
            InitializeComponent();
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
        }

        private void PhuPhi_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dtgv_data.Rows.Clear();
            dtgv_data.ColumnCount = 5;
            dtgv_data.Columns[0].HeaderText = "ID phụ phí";
            dtgv_data.Columns[1].HeaderText = "Tên phụ phí phụ phí";
            dtgv_data.Columns[2].HeaderText = "Giá trị";
            dtgv_data.Columns[3].HeaderText = "Mô tả";
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (!CheckPhuPhi())
            {
                MessageBox.Show("Thêm phụ phí không hợp lệ");
            }
        }
        private bool CheckPhuPhi()
        {
            if (cbb_loaiPP.SelectedIndex == -1 || tx_giaTri.Text == "" || tx_moTa.Text == "")
            {
                return false;
            }
            return true;
        }
    }
}
