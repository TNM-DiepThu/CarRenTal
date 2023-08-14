using Bus.Serviece.Implements;
using Bus.Serviece.Interface;
using Bus.ViewModal;
using Dal.Data;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using TextBox = System.Windows.Forms.TextBox;
using ComboBox = System.Windows.Forms.ComboBox;

namespace CarRenTal.View
{

    public partial class HangXeView : Form
    {
        Guid _id;
        IHangXeServiece _hangXeServiece;
        public HangXeView()
        {
            _hangXeServiece = new HangXeServiece();
            InitializeComponent();
            DataLoad();

        }
        private string GetTrangThaiAsString(int trangThai)
        {
            return trangThai == 0 ? "Hoạt động" : "Ngừng hoạt động";
        }
        private void DataLoad()
        {
            int stt = 1;
            ShowHangXe.ColumnCount = 4;
            ShowHangXe.Columns[0].Name = "STT";
            ShowHangXe.Columns[1].Name = "Id";
            ShowHangXe.Columns[1].Visible = false;
            ShowHangXe.Columns[2].Name = "Name";
            ShowHangXe.Columns[3].Name = "TrangThai";
            ShowHangXe.Rows.Clear();
            foreach (var x in _hangXeServiece.GetAllHangXe())
            {
                string trangThaiAsString = GetTrangThaiAsString(x.TrangThai);
                ShowHangXe.Rows.Add(stt++, x.Id, x.Name, trangThaiAsString);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private HangXeVM GetDataFrom()
        {
            HangXeVM hxview = new HangXeVM();
            {
                hxview.Name = textBox1.Text;
                hxview.TrangThai = rd_hd.Checked ? 1 : 0;
            };
            return hxview;
        }
        private HangXe GetDataFrom2()
        {
            HangXe hxview = new HangXe();
            {
                hxview.Id = _id;
                hxview.Name = textBox1.Text;
                hxview.TrangThai = rd_hd.Checked ? 1 : 0;
            };
            return hxview;
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || !(rd_hd.Checked || rd_khd.Checked))
            {
                MessageBox.Show("Nhập dữ liệu");
            }
            else if (_hangXeServiece.GetAllHangXe().Any(x => x.Name == textBox1.Text))
            {
                MessageBox.Show("Hãng đã tồn tại ");
            }
            else
            {
                MessageBox.Show(_hangXeServiece.CreatHangXe(GetDataFrom()));
                DataLoad();
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự nhập vào là ký tự đặc biệt (không phải ký tự chữ và số)
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Hủy sự kiện KeyPress để không cho phép ký tự đặc biệt xuất hiện trong TextBox
                e.Handled = true;

                // Hiển thị thông báo lỗi bên cạnh TextBox
                errorProvider1.SetError(textBox1, "Không được nhập ký tự đặc biệt.");
            }
            else
            {
                // Xóa thông báo lỗi nếu ký tự nhập vào là hợp lệ
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void ShowHangXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _hangXeServiece.GetAllHangXe().Count || rowIndex == -1) return;
            _id = Guid.Parse(ShowHangXe.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _hangXeServiece.GetAllHangXe().FirstOrDefault(c => c.Id == _id);
            textBox1.Text = obj.Name;
            rd_hd.Checked = (obj.TrangThai == 1) ? true : false;
            rd_khd.Checked = (obj.TrangThai == 0) ? true : false;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị của cột Id từ cell được chọn
                var id = ShowHangXe.Rows[e.RowIndex].Cells["Id"].Value;

                // Kiểm tra xem giá trị Id có tồn tại và là Guid hợp lệ không
                if (id != null && Guid.TryParse(id.ToString(), out Guid hangXeId))
                {
                    // Lưu Id vào biến tạm thời selectedHangXeId
                    _id = hangXeId;
                }
            }


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
                    if (_hangXeServiece.DeleteHangXe(_id))
                    {
                        // Xóa thành công, cập nhật lại DataGridView
                        DataLoad();
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

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || !(rd_hd.Checked || rd_khd.Checked))
            {
                MessageBox.Show("Nhập dữ liệu");
            }
            else if (_hangXeServiece.GetAllHangXe().Any(x => x.Name == textBox1.Text))
            {
                MessageBox.Show("Tên đã tồn tại");
            }
            else
            {
                MessageBox.Show(_hangXeServiece.UpdateHangXe(GetDataFrom2()));
                DataLoad();
            }
        }


    }

}
