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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRenTal.View.QuanLiXe
{
    public partial class MauSacView : Form
    {
        CarRentalDBContext _context;
        IMauSacServiece _mau;
        Guid _id;
        public MauSacView()
        {
            _context = new CarRentalDBContext();
            _mau = new MauSacServiece();
            InitializeComponent();
            LoadData();


        }
        private void LoadData()
        {
            int stt = 1;
            dtg_show.ColumnCount = 3;
            dtg_show.Columns[0].Name = "STT";
            dtg_show.Columns[1].Name = "Id";
            dtg_show.Columns[1].Visible = false;
            dtg_show.Columns[2].Name = "Tên màu sắc";
            dtg_show.Rows.Clear();
            foreach (var x in _mau.GetAll())
            {

                dtg_show.Rows.Add(stt++, x.Id, x.TenMauSac);
            }
        }
        private MauSacVM GetData()
        {
            MauSacVM mauSacVM = new MauSacVM();
            {
                mauSacVM.Id = _id;
                mauSacVM.TenMauSac = tb_name.Text;
            }
            return mauSacVM;
        }
        private bool ContainsSpecialCharacters(string input)
        {
            string pattern = @"^[a-zA-Z0-9 ]+$"; // Cho phép kí tự chữ, số và khoảng trắng
            return !Regex.IsMatch(input, pattern);
        }
        private bool AreFieldsValid()
        {
            // Kiểm tra tên xe không được để trống
            if (string.IsNullOrWhiteSpace(tb_name.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên màu sắc.");
                return false;
            }
            return true;
        }
            private void bt_add_Click(object sender, EventArgs e)
        {
            if(tb_name.Text.Length == 0 || AreFieldsValid() == true ) {
                MessageBox.Show("Nhập đủ dữ liệu hoặc không nhập dữ liệu đặc biệt");
            }
            else { 
            MessageBox.Show( _mau.Creat(GetData()));
            LoadData();}
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if(_id!=Guid.Empty) { 
            MessageBox.Show(_mau.Edit(GetData()));
            LoadData();
            }
            else {
                MessageBox.Show("Chọn đối tượng");
                    }
                
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _mau.GetAll().Count || rowIndex == -1) return;
            _id = Guid.Parse(dtg_show.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _mau.GetAll().FirstOrDefault(c => c.Id == _id);
            tb_name.Text = obj.TenMauSac;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var id = dtg_show.Rows[e.RowIndex].Cells["Id"].Value;

                if (id != null && Guid.TryParse(id.ToString(), out Guid mausacid))
                {
                    _id = mausacid;
                }
            }
        }

        private void bt_dell_Click(object sender, EventArgs e)
        {
            if (_id != Guid.Empty)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (_mau.Delete(_id))
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
    }
}
