using Bus.Serviece.Implements;
using Bus.Serviece.Interface;
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

namespace CarRenTal.View.QuanLiXe
{
    public partial class DangKiemView : Form
    {
        IDangKiemServiece _dk;
        public Guid xeId;
        public Guid _id;
        public DangKiemView(Guid id)
        {
            InitializeComponent();
            _dk = new DangKiemServiece();
            xeId = id;
            LoadData();
        }
        private void LoadData()
        {
            int stt = 1;
            dtg_show.ColumnCount = 5;
            dtg_show.Columns[0].Name = "STT";
            dtg_show.Columns[1].Name = "Id";
            dtg_show.Columns[1].Visible = false;
            dtg_show.Columns[2].Name = "Ngày bắt đầu";
            dtg_show.Columns[3].Name = "Ngày kết thúc";
            dtg_show.Columns[4].Name = "Chi phí";
            dtg_show.Rows.Clear();
            foreach (var x in _dk.GetAllDK(xeId))
            {


                dtg_show.Rows.Add(stt++, x.Id, x.NgayDangKiem, x.NgayHetHan, x.ChiPhi);
            }
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _dk.GetAllDK(xeId).Count || rowIndex == -1) return;
            _id = Guid.Parse(dtg_show.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _dk.GetAllDK(xeId).FirstOrDefault(c => c.Id == _id);
            dtp_bd.Text = obj.NgayDangKiem.ToString();
            dtp_kt.Text = obj.NgayHetHan.ToString();
            tb_cp.Text = obj.ChiPhi.ToString();

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var id = dtg_show.Rows[e.RowIndex].Cells["Id"].Value;

                if (id != null && Guid.TryParse(id.ToString(), out Guid bdid))
                {
                    _id = bdid;
                }
            }
        }
        private DangKiem GetData()
        {
            DangKiem b = new DangKiem();
            {
                b.Id = _id;
                b.NgayDangKiem = DateTime.Parse(dtp_bd.Text);
                b.NgayHetHan = DateTime.Parse(dtp_kt.Text);
                b.ChiPhi = decimal.Parse(tb_cp.Text);
                b.IdXe = xeId;
            }
            return b;
        }
        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (dtp_bd == null || dtp_kt == null || tb_cp.Text == "")
            {
                MessageBox.Show("Nhập đủ dữ liệu");
            }
            else
            if (_id == Guid.Empty) { MessageBox.Show("vui lòng click vào STT"); }
            else if (dtp_bd.Value > dtp_kt.Value) { MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc"); }
            else
            if (_dk.Edit(GetData(), xeId))
            {
                MessageBox.Show("thành công");
                LoadData();
            }
            else { MessageBox.Show("Không thành công"); }
        }
    }
}
