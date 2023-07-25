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
        KhachHangRepo _khRepo;

        public event EventHandler MyEventHandler;
        public QLKHView()
        {
            InitializeComponent();
            _lstKhachHang = new List<KhachHang>();
            _khRepo = new KhachHangRepo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void GetDGV()
        {
            dgvQLKH.Rows.Clear();
            dgvQLKH.ColumnCount = 9;

            dgvQLKH.Columns[0].Name = "Mã KH";
            dgvQLKH.Columns[1].Name = "Họ và tên";
            dgvQLKH.Columns[2].Name = "Số CCCD";
            dgvQLKH.Columns[3].Name = "Địa Chỉ";
            dgvQLKH.Columns[4].Name = "Giới tính";
            dgvQLKH.Columns[5].Name = "Ngày sinh";
            dgvQLKH.Columns[5].Name = "SĐT";
            dgvQLKH.Columns[6].Name = "Người thân";

            _lstKhachHang = _khRepo.GetALL();

            foreach (var i in _lstKhachHang)
            {
                dgvQLKH.Rows.Add(i.Id, i.Name, i.DiaChi, i.GioiTinh, i.SDT, i.NguoiThans);
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
            //new TTKHchiTiet();
            //TTKHchiTiet tTKHchiTiet = new TTKHchiTiet();
            //tTKHchiTiet._QLKHView = this;  
            //tTKHchiTiet.MyEvent += MyEventHandler;
            //tTKHchiTiet.MyMethod(dgvQLKH.CurrentRow.Cells[0].Value.ToString());
            TTKHchiTiet tTKHchiTiet = new TTKHchiTiet();
            tTKHchiTiet.Show();
        }

        //public class MyObject
        //{
        //    public string Data { get; set; }
        //}


        private void dgvQLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           //MyObject myObject = new MyObject();

           // foreach (var i in _lstKhachHang)
           // {
           //     myObject.Data = 
           // }
        }
    }
}
