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
    public partial class EditXeView : Form
    {
        private Guid _id;
        private Guid xeId;
        IXeServiece _xes;
        IMauSacServiece _mau;
        ILoaiXeServiece _loai;
        IHangXeServiece _hx;
        private QuanLiXeView _quanLiXeView;

        public EditXeView(Guid id, QuanLiXeView quanLiXeView)
        {
            InitializeComponent();
            _id = id;
            _xes = new XeServiece();
            _mau = new MauSacServiece();
            _loai = new LoaiXeServiece();
            _hx = new HangXeServiece();
            _quanLiXeView = quanLiXeView;
            addCCB();
            loadform();
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

            // Kiểm tra biển số không được để trống
            if (string.IsNullOrWhiteSpace(tb_bienso.Text))
            {
                MessageBox.Show("Vui lòng nhập Biển số.");
                return false;
            }
            //if (ContainsSpecialCharacters(tb_bienso.Text))
            //{
            //    MessageBox.Show("Tên xe không được chứa kí tự đặc biệt.");
            //    return false;
            //}

            // Kiểm tra số khung không được để trống
            if (string.IsNullOrWhiteSpace(tb_sokhung.Text))
            {
                MessageBox.Show("Vui lòng nhập Số khung.");
                return false;
            }
            if (ContainsSpecialCharacters(tb_sokhung.Text))
            {
                MessageBox.Show("Số khung không được chứa kí tự đặc biệt.");
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
                MessageBox.Show("Số máy không được chứa kí tự đặc biệt.");
                return false;
            }
            // Kiểm tra đơn giá không được để trống
            if (string.IsNullOrWhiteSpace(tb_dongia.Text))
            {
                MessageBox.Show("Vui lòng nhập Đơn giá.");
                return false;
            }

            // Kiểm tra số công tơ không được để trống
            if (string.IsNullOrWhiteSpace(tb_sct.Text))
            {
                MessageBox.Show("Vui lòng nhập Số công tơ.");
                return false;
            }

            // Kiểm tra chi phí không được để trống

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


            return true; // Tất cả các trường đều hợp lệ
        }
        private XeVM GetDaTa()
        {
            XeVM xes = new XeVM();
            {
                xes.ID = _id;
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
        private void EditXeView_Load(object sender, EventArgs e)
        {

        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (Checkvali() == true)
            {
                if (_xes.UpdateM(GetDaTa()))

                    MessageBox.Show("Thành công");


                else MessageBox.Show("Không thành công");
            }
            _quanLiXeView.LoadData();
        }
        private void loadform()
        {
            var obj = _xes.GetAll().FirstOrDefault(c => c.ID == _id);
            tb_bienso.Text = obj.BienSo;
            tb_sokhung.Text = obj.SoKhung;
            tb_somay.Text = obj.SoMay;
            tb_sct.Text = obj.SoCongTo.ToString();
            cb_name.Text = obj.TenXe;
            tb_dongia.Text = obj.DonGia.ToString();
            cb_mausac.Text = obj.MauSac;
        }
        private List<string> tenXeList;
        private void LoadTenXeByTenHangXe()
        {
            // Lấy danh sách TenXe từ bảng LoaiXe dựa vào TenHangXe đã chọn
            string selectedTenHangXe = cb_hangxe.SelectedItem as string;
            if (selectedTenHangXe != null)
            {
                tenXeList = _loai.GetAll().Where(l => l.TenHangXe == selectedTenHangXe).Select(l => l.Name).ToList();

                // Đổ danh sách TenXe vào combobox cb_tenxe
                cb_name.Items.Clear();
                cb_name.Items.AddRange(tenXeList.ToArray());
            }
        }
        private void addCCB()
        {
            cb_mausac.Items.Clear(); // Xóa các phần tử cũ (nếu có)
            foreach (var x in _mau.GetAll())
            {
                cb_mausac.Items.Add(x.TenMauSac);
            }
            cb_name.Items.Clear(); // Xóa các phần tử cũ (nếu có)
            foreach (var x in _loai.GetAll())
            {
                cb_name.Items.Add(x.Name);
            }
            cb_hangxe.Items.Clear();
            foreach (var x in _hx.GetAllHangXe())
            {
                cb_hangxe.Items.Add(x.Name);
            }

        }

        private void cb_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_hangxe_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTenXeByTenHangXe();

        }

        private void EditXeView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _quanLiXeView.LoadData();
        }
    }
}
