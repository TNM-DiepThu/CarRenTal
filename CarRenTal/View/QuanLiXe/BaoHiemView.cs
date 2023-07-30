using Bus.Serviece.Implements;
using Bus.Serviece.Interface;
using Bus.ViewModal;
using Dal.Data;
using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace CarRenTal.View.QuanLiXe
{
    public partial class BaoHiemView : Form
    {
        CarRentalDBContext _context;
        IBaoHiemServiece _baohiem;
        Guid _id;
        public BaoHiemView()
        {
            InitializeComponent();
            _context = new CarRentalDBContext();
            _baohiem = new BaoHiemServiece();
            LoadData();
        }
        private string GetTrangThaiAsString(int trangThai)
        {
            return trangThai == 0 ? "Hoạt động" : "Không hoạt động";
        }
        private void LoadData()
        {
            int stt = 1;
            dtg_show.ColumnCount = 4;
            dtg_show.Columns[0].Name = "STT";
            dtg_show.Columns[1].Name = "Id";
            dtg_show.Columns[1].Visible = false;
            dtg_show.Columns[2].Name = "Name";
            dtg_show.Columns[3].Name = "TrangThai";
            dtg_show.Rows.Clear();
            foreach (var x in _baohiem.GetAll())
            {
                string trangThaiAsString = GetTrangThaiAsString(x.TrangThai);
                dtg_show.Rows.Add(stt++, x.Id, x.LoaiBaoHiem, trangThaiAsString);
            }
        }
        private BaoHiemVM GetData()
        {
            BaoHiemVM baoHiemVM = new BaoHiemVM();
            {
                baoHiemVM.Id = _id;
                baoHiemVM.LoaiBaoHiem = tb_name.Text;
                baoHiemVM.TrangThai = rd_1.Checked ? 1 : 0;
            }
            return baoHiemVM;
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            var existingMauSac = _context.baoHiems.FirstOrDefault(h => h.LoaiBaoHiem == tb_name.Text);

            if (existingMauSac != null)
            {

                MessageBox.Show("Loại bảo hiểm đã tồn tại");
            }
            else if (tb_name.Text == "" || !(rd_0.Checked || rd_1.Checked))
            {
                MessageBox.Show("Nhập giá trị");
            }
            else
            if (_baohiem.Add(GetData()))
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
            }


            else
            {
                MessageBox.Show("Thêm không thành công");
            }

        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _baohiem.GetAll().Count || rowIndex == -1) return;
            _id = Guid.Parse(dtg_show.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _baohiem.GetAll().FirstOrDefault(c => c.Id == _id);
            tb_name.Text = obj.LoaiBaoHiem;
            rd_0.Checked = (obj.TrangThai == 0) ? true : false;
            rd_1.Checked = (obj.TrangThai == 1) ? true : false;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var id = dtg_show.Rows[e.RowIndex].Cells["Id"].Value;
                if (id != null && Guid.TryParse(id.ToString(), out Guid hangXeId))
                {
                    _id = hangXeId;
                }
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "" || !(rd_0.Checked || rd_1.Checked))
            {
                MessageBox.Show("Nhập giá trị");
            }
            else
                       if (_baohiem.Edit(GetData()))
            {

                MessageBox.Show("Thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
        }

        private void bt_dell_Click(object sender, EventArgs e)
        {
            if (_id != Guid.Empty)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (_baohiem.Delete(_id))
                    {
                        LoadData();
                        _id = Guid.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công. Hãy thử lại sau.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
