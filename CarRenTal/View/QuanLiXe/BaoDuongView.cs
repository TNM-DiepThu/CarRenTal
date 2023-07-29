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
    public partial class BaoDuongView : Form
    {
        private Guid _id;
        private Guid xeId;
        IBaoDuongServiece _baoduong;
        public BaoDuongView(Guid id)
        {
            InitializeComponent();
            _baoduong = new BaoDuongServiece();
            xeId = id;
            LoadData();
            Auto();
        }
        private string GetTrangThaiAsString(int trangThai)
        {
            return trangThai == 0 ? "Đang bão dưỡng" : "Kết thúc bảo dưỡng";
        }
        private void LoadData()
        {
            int stt = 1;
            dtg_show.ColumnCount = 8;
            dtg_show.Columns[0].Name = "STT";
            dtg_show.Columns[1].Name = "Id";
            dtg_show.Columns[1].Visible = false;
            dtg_show.Columns[2].Name = "Ngày bắt đầu";
            dtg_show.Columns[3].Name = "Ngày kết thúc";
            dtg_show.Columns[4].Name = "Chi phí";
            dtg_show.Columns[5].Name = "Số công tơ bảo dưỡng";
            dtg_show.Columns[7].Name = "Trạng thái";
            dtg_show.Columns[6].Name = "Chi Tiết";
            dtg_show.Rows.Clear();
            foreach (var x in _baoduong.GetAll(xeId))
            {
                string trangThaiAsString = GetTrangThaiAsString(x.TrangThai);

                dtg_show.Rows.Add(stt++, x.Id, x.NgayDangKiem, x.NgayHetHan, x.ChiPhi, x.SoCongToBaoDuong,x.ChiTiet, trangThaiAsString);
            }
        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private BaoDuong GetData()
        {
            BaoDuong b = new BaoDuong();
            {
                b.Id = _id;
                b.NgayDangKiem = DateTime.Parse(dtp_bd.Text);
                b.NgayHetHan = DateTime.Parse(dtp_kt.Text);
                b.ChiPhi = decimal.Parse(tb_cphi.Text);
                b.SoCongToBaoDuong = int.Parse(tb_ct.Text);
                b.ChiTiet = tb_chitiet.Text;
                b.IdXe = xeId;
            }
            return b;
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (_baoduong.Add(GetData(), xeId))
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (_baoduong.Edit(GetData(), xeId))
            {
                MessageBox.Show("Sửa thành công");
                _id = Guid.Empty;
                LoadData();
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _baoduong.GetAll(xeId).Count || rowIndex == -1) return;
            _id = Guid.Parse(dtg_show.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _baoduong.GetAll(xeId).FirstOrDefault(c => c.Id == _id);
            dtp_bd.Text = obj.NgayDangKiem.ToString();
            dtp_kt.Text = obj.NgayHetHan.ToString();
            tb_cphi.Text = obj.ChiPhi.ToString();
            tb_ct.Text = obj.SoCongToBaoDuong.ToString();
            tb_chitiet.Text = obj.ChiTiet.ToString();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var id = dtg_show.Rows[e.RowIndex].Cells["Id"].Value;

                if (id != null && Guid.TryParse(id.ToString(), out Guid bdid))
                {
                    _id = bdid;
                }
            }
        }
        private void Auto()
        {
            if (_baoduong.update(1))
            {
                MessageBox.Show("update time");
            }
            else
            {
                MessageBox.Show("update time");
            }
        }
    }



}
