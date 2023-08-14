using Bus.Serviece.Implements;
using Bus.Serviece.Interface;
using Bus.ViewModal;
using Dal.Data;
using Dal.Modal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace CarRenTal.View.QuanLiXe
{
    public partial class LoaiXeView : Form
    {
        CarRentalDBContext _context;
        Guid _id;
        ILoaiXeServiece _loaiXeServiece;
        IHangXeServiece _dshxe;
        public LoaiXeView()
        {
            _context = new CarRentalDBContext();
            _loaiXeServiece = new LoaiXeServiece();
            _dshxe = new HangXeServiece();
            InitializeComponent();
            cbb_hangxe.Items.Clear(); // Xóa các phần tử cũ (nếu có)
            foreach (var hangXe in _dshxe.GetAllHangXe())
            {
                cbb_hangxe.Items.Add(hangXe.Name);
            }
            LoadData();
        }
        private void LoaiXeView_Load(object sender, EventArgs e)
        {
            // ...
            tb_name.KeyPress += tb_name_KeyPress;
            tb_lnl.KeyPress += tb_lnl_KeyPress;
        }

        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập chữ cái, chữ số và dấu cách
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tb_lnl_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập chữ cái và chữ số
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private string GetTrangThaiAsString(int trangThai)
        {
            return trangThai == 1 ? "Hoạt động" : "Ngừng hoạt động";
        }

        private void LoadData()
        {
            //List<LoaiXe> danhSachLoaiXe = _loaiXeServiece.GetAll();
            int stt = 1;
            dtg_show.ColumnCount = 8;
            dtg_show.Columns[0].Name = "STT";
            dtg_show.Columns[1].Name = "Id";
            dtg_show.Columns[1].Visible = false;
            dtg_show.Columns[2].Name = "Tên Loại Xe";
            dtg_show.Columns[3].Name = "Loại nhiên liệu";
            dtg_show.Columns[4].Name = "Số ghế";
            dtg_show.Columns[5].Name = "Loại số xe";
            dtg_show.Columns[6].Name = "Hãng xe";
            dtg_show.Columns[7].Name = "Trạng Thái";
            dtg_show.Rows.Clear();
            foreach (var x in _loaiXeServiece.GetAll())
            {
                string trangThaiAsString = GetTrangThaiAsString(x.TrangThai);
                string tenHangXe = x.TenHangXe;
                dtg_show.Rows.Add(stt++, x.Id, x.Name, x.LoaiNguyenLieu, x.SoGhe, x.LoaiSoXe, tenHangXe, trangThaiAsString);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }


        //private LoaiXe GetDataFrom()
        //{


        //    return lxview;
        //}
        private void bt_add_Click(object sender, EventArgs e)
        {
            bool tb1 = IsComboBoxNullOrEmpty(tb_lnl);
            bool tb2 = IsTextBoxNullOrEmpty(tb_name);
            bool tb3 = IsComboBoxNullOrEmpty(tb_loaisoxe);
            bool cb1 = IsComboBoxNullOrEmpty(cbb_hangxe);
            bool cb2 = IsComboBoxNullOrEmpty(tb_soghe);
            if (tb1 || tb2 || cb1 || cb2 || tb3 || !(rd_0.Checked || rd_1.Checked))
            {
                MessageBox.Show("Nhập đủ giá trị");
            }
            else if (_loaiXeServiece.GetAll().Any(x => x.Name == tb_name.Text))
            {
                MessageBox.Show("Tên loại xe đã tồn tại ");
            }
            else
            {
                LoaiXe lxview = new LoaiXe();
                {
                    lxview.Name = tb_name.Text;
                    lxview.LoaiNguyenLieu = tb_lnl.Text;
                    lxview.SoGhe = int.Parse(tb_soghe.Text);
                    lxview.LoaiSoXe = tb_loaisoxe.Text;
                    lxview.TrangThai = rd_0.Checked ? 1 : 0;

                };

                HangXe hangXe = _context.hangXes.FirstOrDefault(h => h.Name == cbb_hangxe.Text);
                if (hangXe != null)
                {
                    lxview.IdHangXe = hangXe.Id;
                    lxview.HangXe = hangXe;
                }
                _context.Add(lxview);
                _context.SaveChanges(); if (_loaiXeServiece.Creat(lxview))
                {
                    MessageBox.Show("Thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }


            }
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _loaiXeServiece.GetAll().Count || rowIndex == -1) return;
            _id = Guid.Parse(dtg_show.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _loaiXeServiece.GetAll().FirstOrDefault(c => c.Id == _id);
            tb_name.Text = obj.Name;
            tb_lnl.Text = obj.LoaiNguyenLieu;
            tb_soghe.Text = obj.SoGhe.ToString();
            tb_loaisoxe.Text = obj.LoaiSoXe;


            rd_0.Checked = (obj.TrangThai == 1) ? true : false;
            rd_1.Checked = (obj.TrangThai == 0) ? true : false;


            var id = dtg_show.Rows[e.RowIndex].Cells["Id"].Value;


            if (id != null && Guid.TryParse(id.ToString(), out Guid hangXeId))
            {

                _id = hangXeId;


                var selectedLoaiXe = _loaiXeServiece.GetAll().FirstOrDefault(c => c.IdHang == _id);
                if (selectedLoaiXe != null)
                {
                    string tenHangXe = selectedLoaiXe.TenHangXe;
                    cbb_hangxe.Text = tenHangXe;
                }
            }
        }

        private void cbb_hangxe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            if (_id != Guid.Empty)
            {
                // Hiển thị thông báo hỏi người dùng có đồng ý xóa hay không
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Người dùng đã đồng ý xóa, gọi phương thức xóa và kiểm tra kết quả
                    if (_loaiXeServiece.Delete(_id))
                    {
                        // Xóa thành công, cập nhật lại DataGridView
                        LoadData();
                        _id = Guid.Empty; // Đặt lại giá trị _id về mặc định
                    }
                    else
                    {
                        // Xóa không thành công, xử lý thông báo lỗi nếu cần
                        MessageBox.Show("Xóa không thành công. Hãy thử lại sau.");
                    }
                }
                // Người dùng không đồng ý xóa hoặc nhấn nút hủy, không thực hiện xóa.
            }
            else
            {
                // Không có dòng nào được chọn, thông báo cho người dùng chọn một dòng trước khi xóa (nếu cần).
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private LoaiXeVM GetDataFrom2()
        {
            LoaiXeVM view = new LoaiXeVM();
            {
                view.Id = _id; // _id là biến lưu giá trị Id của đối tượng LoaiXe được chọn trong DataGridView
                view.Name = tb_name.Text; // tb_name là TextBox chứa tên loại xe
                view.LoaiNguyenLieu = tb_lnl.Text; // tb_lnl là TextBox chứa loại nhiên liệu
                view.SoGhe = Int32.Parse(tb_soghe.Text); // tb_soghe là TextBox chứa số ghế (đã ép kiểu thành int)
                view.LoaiSoXe = tb_loaisoxe.Text; // tb_loaisoxe là TextBox chứa loại số xe // tb_nltt là TextBox chứa nhiên liệu tiêu thụ
                view.TenHangXe = cbb_hangxe.Text; // cbb_hangxe là ComboBox chứa Tên hãng xe
                view.TrangThai = rd_1.Checked ? 1 : 0; // rd_1 là RadioButton chứa Trạng thái (0: Hoạt động, 1: Ngừng hoạt động)
            }
            return view;
        }
        private void bt_edit_Click(object sender, EventArgs e)
        {
            bool tb1 = IsComboBoxNullOrEmpty(tb_lnl);
            bool tb2 = IsTextBoxNullOrEmpty(tb_name);
            bool tb3 = IsComboBoxNullOrEmpty(tb_loaisoxe);
            bool cb1 = IsComboBoxNullOrEmpty(cbb_hangxe);
            bool cb2 = IsComboBoxNullOrEmpty(tb_soghe);
            if (tb1 || tb2 || cb1 || cb2 || tb3 || !(rd_0.Checked || rd_1.Checked))
            {
                MessageBox.Show("Nhập đủ giá trị");
            }
           
            else
            {
                var updatedData = GetDataFrom2();

                // Gọi phương thức cập nhật dữ liệu trong cơ sở dữ liệu
                if (_loaiXeServiece.Edit(updatedData))
                {
                    MessageBox.Show("Thành công");
                    LoadData();
                }
                else
                {
                    // Cập nhật không thành công, xử lý thông báo lỗi nếu cần
                    MessageBox.Show("Cập nhật không thành công. Hãy thử lại sau.");
                }
            }
        }
        private bool IsTextBoxNullOrEmpty(TextBox textBox)
        {
            return string.IsNullOrEmpty(textBox.Text);
        }
        private bool IsComboBoxNullOrEmpty(ComboBox comboBox)
        {
            return comboBox.SelectedIndex == -1;
        }
    }
}
