using Bus.Serviece.Implements;
using Dal.Modal;
using Microsoft.VisualBasic;
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
    public partial class TTKHchiTiet : Form
    {
        public QLKHView _QLKHView; //Create from QLKh at Add Kh
        List<KhachHang> _lstKH;
        List<NguoiThan> _lstNT;
        KhachHangService _khachHangService;
        NguoiThanService _NguoiThanService;
        //public event EventHandler MyEvent;


        //Guid _id = Guid.Empty;
        public TTKHchiTiet(QLKHView QLKH)
        {
            InitializeComponent();
            this._QLKHView = QLKH;
            _lstKH = new List<KhachHang>();
            _lstNT = new List<NguoiThan>();
            _khachHangService = new KhachHangService();
            _NguoiThanService = new NguoiThanService();
        }
        private void TTKHchiTiet_Load(object sender, EventArgs e)
        {
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //_QLKHView.dgvQLKH.Rows.Add(){ };
            try
            {
                var kh = new KhachHang()
                {
                    Id = Guid.NewGuid(),
                    Name = txtHoTenKH.Text,
                    GioiTinh = bool.Parse(cbbGioiTinhKH.Text),
                    DiaChi = txtDiaChiKH.Text,
                    SDT = txtSdtKH.Text,
                    CCCD = txtCCCDKH.Text,
                    NgaySinh = DateTime.Parse(dtpNgaySinhKh.Text)
                };
                _lstKH.Add(kh);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception)
            {

                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void cbbGioiTinhKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
