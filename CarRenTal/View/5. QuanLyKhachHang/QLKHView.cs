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

namespace CarRenTal.View._5._QuanLyKhachHang
{
    public partial class QLKHView : Form
    {
        List<KhachHang> _lstKhachHang;
        KhachHangService _kHService;


        public event EventHandler MyEventHandler;
        public QLKHView()
        {
            InitializeComponent();
            _lstKhachHang = new List<KhachHang>();
            _kHService = new KhachHangService();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void GetDGV()
        {
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
            txtHoTenKH.Text = dgvQLKH.CurrentRow.Cells[1].Value.ToString();
            cbbGioiTinhKH.SelectedIndex = dgvQLKH.CurrentRow.Cells[2].Value.ToString() == "Nam"? 1:0;
            dtpNgaySinhKh.Value = DateTime.Parse(dgvQLKH.CurrentRow.Cells[3].Value.ToString());
            txtCCCDKH.Text = dgvQLKH.CurrentRow.Cells[4].Value.ToString();
            txtDiaChiKH.Text = dgvQLKH.CurrentRow.Cells[5].Value.ToString();
            txtSdtKH.Text = dgvQLKH.CurrentRow.Cells[1].Value.ToString();
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
                if (MessageBox.Show("Bạn có muốn cập nhật không", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    _kHService.UpdateKhachHang(new KhachHang()
                    {
                        Id = Guid.NewGuid(),
                        Name = txtHoTenKH.Text,
                        GioiTinh = cbbGioiTinhKH.SelectedIndex == 0 ? true : false,
                        DiaChi = txtDiaChiKH.Text,
                        SDT = txtSdtKH.Text,
                        CCCD = txtCCCDKH.Text,
                        NgaySinh = DateTime.Parse(dtpNgaySinhKh.Text)
                    });
                    MessageBox.Show("Sửa thành công");
                    QLKHView_Load(null, null);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại");
            }
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

            foreach (var i in _lstKhachHang.Where(c => c.Name.Contains(txtSearch.Text)))
            {
                dgvQLKH.Rows.Add(i.Id, i.Name, (i.GioiTinh ? "Nam" : "Nữ"), i.DiaChi, i.SDT, i.CCCD, i.NgaySinh);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHoTenKH.Text = "";
            cbbGioiTinhKH.Text = "";
            dtpNgaySinhKh.Text = "";
            txtCCCDKH.Text = "";
            txtDiaChiKH.Text = "";
            txtSdtKH.Text = "";
        }
    }
}
