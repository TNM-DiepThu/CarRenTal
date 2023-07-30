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

        public EditXeView(Guid id)
        {
            InitializeComponent();
            _id = id;
            _xes = new XeServiece();
            _mau = new MauSacServiece();
            _loai = new LoaiXeServiece();
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
            }
            return xes;
        }
        private void EditXeView_Load(object sender, EventArgs e)
        {

        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (_xes.UpdateM(GetDaTa()))

                MessageBox.Show("Thành công");


            else MessageBox.Show("Không thành công");


        }
    }
}
