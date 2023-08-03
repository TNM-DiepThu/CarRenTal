using Bus.Serviece.Implements;
using Bus.Serviece.Interface;
using Bus.ViewModal;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRenTal.View.QuanLiXe
{
    public partial class ThemXe : Form
    {
        IXeServiece _xesv;
        IMauSacServiece _mauSacServiece;
        ILoaiXeServiece _loaiXeServiece;
        IDangKiemServiece _dk;
        IHangXeServiece _hx;
        Guid _id;
        Guid _id2;
        QuanLiXeView _quanLiXeView;
        public ThemXe(QuanLiXeView quanLiXeView)
        {
            _xesv = new XeServiece();
            _mauSacServiece = new MauSacServiece();
            _loaiXeServiece = new LoaiXeServiece();
            _dk = new DangKiemServiece();
            _hx = new HangXeServiece();
            InitializeComponent();
            addCCB();
            _quanLiXeView = quanLiXeView;
        }
        private bool IsInteger(string input)
        {
            return int.TryParse(input, out _);
        }

        // Phương thức kiểm tra số thập phân hợp lệ
        private bool IsDecimal(string input)
        {
            return decimal.TryParse(input, out _);
        }
        private bool ContainsSpecialCharacters(string input)
        {
            string pattern = @"^[a-zA-Z0-9 ]+$";
            return !Regex.IsMatch(input, pattern);
        }
        private bool Checkvali()
        {
            // Kiểm tra tên xe không được để trống
            if (string.IsNullOrWhiteSpace(cb_name.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên xe.");
                return false;
            }
            if (ContainsSpecialCharacters(cb_name.Text))
            {
                MessageBox.Show("Tên xe không được chứa kí tự đặc biệt.");
                return false;
            }

            // Kiểm tra biển số không được để trống
            if (string.IsNullOrWhiteSpace(tb_bienso.Text))
            {
                MessageBox.Show("Vui lòng nhập Biển số.");
                return false;
            }
            if (ContainsSpecialCharacters(tb_bienso.Text))
            {
                MessageBox.Show("Tên xe không được chứa kí tự đặc biệt.");
                return false;
            }

            // Kiểm tra số khung không được để trống
            if (string.IsNullOrWhiteSpace(tb_sokhung.Text))
            {
                MessageBox.Show("Vui lòng nhập Số khung.");
                return false;
            }
            if (ContainsSpecialCharacters(tb_sokhung.Text))
            {
                MessageBox.Show("Tên xe không được chứa kí tự đặc biệt.");
                return false;
            }

            // Kiểm tra số máy không được để trống
            if (string.IsNullOrWhiteSpace(tb_somay.Text))
            {
                MessageBox.Show("Vui lòng nhập Số máy.");
                return false;
            }
            if (ContainsSpecialCharacters(tb_somay.Text))
            {
                MessageBox.Show("Tên xe không được chứa kí tự đặc biệt.");
                return false;
            }
            // Kiểm tra đơn giá không được để trống
            if (string.IsNullOrWhiteSpace(tb_dongia.Text))
            {
                MessageBox.Show("Vui lòng nhập Đơn giá.");
                return false;
            }

            // Kiểm tra màu sắc không được để trống
            if (string.IsNullOrWhiteSpace(cb_mausac.Text))
            {
                MessageBox.Show("Vui lòng chọn Màu sắc.");
                return false;
            }

            // Kiểm tra số công tơ không được để trống
            if (string.IsNullOrWhiteSpace(tb_sct.Text))
            {
                MessageBox.Show("Vui lòng nhập Số công tơ.");
                return false;
            }

            // Kiểm tra chi phí không được để trống
            if (string.IsNullOrWhiteSpace(tb_chiphi.Text))
            {
                MessageBox.Show("Vui lòng nhập Chi phí.");
                return false;
            }

            // Kiểm tra ngày đăng kiểm không được để trống
            if (dtp_ndk.Value == null)
            {
                MessageBox.Show("Vui lòng chọn Ngày đăng kiểm.");
                return false;
            }

            // Kiểm tra ngày hết hạn không được để trống
            if (dtp_nhh.Value == null)
            {
                MessageBox.Show("Vui lòng chọn Ngày hết hạn.");
                return false;
            }
            if (dtp_ndk.Value > dtp_nhh.Value)
            {
                MessageBox.Show("Ngày đăng kí phải nhỏ hơn ngày hết hạn");
                return false;
            }
            if (!IsInteger(tb_sct.Text))
            {
                MessageBox.Show("Số công tơ phải là số nguyên.");
                return false;
            }

            // Kiểm tra Đơn giá
            if (!IsDecimal(tb_dongia.Text))
            {
                MessageBox.Show("Đơn giá phải là số.");
                return false;
            }
            //Kiểm tra chi phí
            if (!IsDecimal(tb_chiphi.Text))
            {
                MessageBox.Show("Chi phí phải là số.");
                return false;
            }


            return true; // Tất cả các trường đều hợp lệ
        }
        private void addCCB()
        {
            cb_mausac.Items.Clear(); // Xóa các phần tử cũ (nếu có)
            foreach (var x in _mauSacServiece.GetAll())
            {
                cb_mausac.Items.Add(x.TenMauSac);
            }
            cb_name.Items.Clear(); // Xóa các phần tử cũ (nếu có)
            foreach (var x in _loaiXeServiece.GetAll())
            {
                cb_name.Items.Add(x.Name);
            }
            cb_hangxe.Items.Clear();
            foreach (var x in _hx.GetAllHangXe())
            {
                cb_hangxe.Items.Add(x.Name);
            }

        }

        private XeVM GetDaTa()
        {
            XeVM xes = new XeVM();
            {
                xes.BienSo = tb_bienso.Text;
                xes.SoKhung = tb_sokhung.Text;
                xes.SoMay = tb_somay.Text;
                xes.DonGia = decimal.Parse(tb_dongia.Text);
                if (int.TryParse(tb_sct.Text, out int soCongTo))
                {
                    xes.SoCongTo = soCongTo;
                }
                else
                {
                    MessageBox.Show("giá trị ko hợp lệ");
                }
                xes.TrangThai = rd_0.Checked ? 0 : 1;
                xes.TenXe = cb_name.Text;
                xes.MauSac = cb_mausac.Text;
            }
            return xes;
        }
        private DangKiem GetDataDK()
        {

            DangKiem dangKiem = new DangKiem();
            {
                dangKiem.NgayDangKiem = DateTime.Parse(dtp_ndk.Text);
                dangKiem.NgayHetHan = DateTime.Parse(dtp_nhh.Text);
                dangKiem.ChiPhi = int.Parse(tb_chiphi.Text);
            }
            return dangKiem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Checkvali() == true)
            {

                if (_xesv.Add(GetDaTa(), GetDataDK()))
                {

                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }
        private List<string> tenHangXeList;
        private List<string> tenXeList;
        private void LoadTenXeByTenHangXe()
        {
            // Lấy danh sách TenXe từ bảng LoaiXe dựa vào TenHangXe đã chọn
            string selectedTenHangXe = cb_hangxe.SelectedItem as string;
            if (selectedTenHangXe != null)
            {
                tenXeList = _loaiXeServiece.GetAll().Where(l => l.TenHangXe == selectedTenHangXe).Select(l => l.Name).ToList();

                // Đổ danh sách TenXe vào combobox cb_tenxe
                cb_name.Items.Clear();
                cb_name.Items.AddRange(tenXeList.ToArray());
            }
        }
        private void ThemXe_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ThemXe_FormClosed(object sender, FormClosedEventArgs e)
        {
            _quanLiXeView.LoadData();
        }

        private void cb_hangxe_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTenXeByTenHangXe();
        }
    }
}

