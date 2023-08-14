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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRenTal.View.QuanLiXe
{
    public partial class XeBaoHiemView : Form
    {
        private Guid _id;
        private Guid xeId;
        IXeBaoHiemServiece _bhsv;
        IBaoHiemServiece _bh;
        public XeBaoHiemView(Guid id)
        {
            InitializeComponent();
            xeId = id;
            _bhsv = new XeBaoHiemServiece();
            _bh = new BaoHiemServiece();
            addCCB();
            LoadData();
        }
        private void LoadData()
        {
            int stt = 1;
            dtg_show.ColumnCount = 7;
            dtg_show.Columns[0].Name = "STT";
            dtg_show.Columns[1].Name = "Id";
            dtg_show.Columns[1].Visible = false;
            dtg_show.Columns[2].Name = "Ngày bắt đầu";
            dtg_show.Columns[3].Name = "Ngày kết thúc";
            dtg_show.Columns[4].Name = "Loại bh";
            dtg_show.Columns[5].Name = "Chi phí";
            dtg_show.Columns[6].Name = "Trạng thái";
            dtg_show.Rows.Clear();
            foreach (var x in _bhsv.GetAll(xeId))
            {
                string trangThaiAsString = GetTrangThaiAsString(x.TrangThai);


                dtg_show.Rows.Add(stt++, x.Id, x.NgayBatDau, x.NgayKetThuc, x.LoaiBaoHiem, x.ChiPhi, trangThaiAsString);
            }
        }

        private XeBaoHiemVM GetData()
        {
            XeBaoHiemVM b = new XeBaoHiemVM();

            // Lấy thông tin từ giao diện người dùng và gán vào đối tượng XeBaoHiemVM
            b.Id = _id;
            b.NgayBatDau = DateTime.Parse(dtp_bd.Text);
            b.NgayKetThuc = DateTime.Parse(dtp_kt.Text);
            b.ChiPhi = decimal.Parse(tb_cp.Text);
            b.LoaiBaoHiem = cb_lbh.Text;
            b.IdXe = xeId;

            // Lấy IdBH (Id của BaoHiem) dựa trên LoaiBaoHiem (tên bảo hiểm)


            return b;
        }
        private string GetTrangThaiAsString(int trangThai)
        {
            return trangThai == 1 ? "Còn hạn" : "Hết hạn";
        }
        private void addCCB()
        {
            cb_lbh.Items.Clear(); // Xóa các phần tử cũ (nếu có)
            foreach (var x in _bh.GetAll())
            {
                cb_lbh.Items.Add(x.LoaiBaoHiem);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (dtp_bd == null || dtp_kt == null || cb_lbh == null)
            {
                MessageBox.Show("Nhập giá trị");
            }
            else if (dtp_bd.Value > dtp_kt.Value) { MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc"); }
            else

            if (_bhsv.Add(GetData(), xeId)) { MessageBox.Show("Thành công"); LoadData(); }
            else { MessageBox.Show("Không thành công"); }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (dtp_bd == null || dtp_kt == null || cb_lbh == null)
            {
                MessageBox.Show("Nhập giá trị");
            }
            else if (dtp_bd.Value > dtp_kt.Value) { MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc"); }
            else
            if (_bhsv.Edit(GetData(), xeId)) { MessageBox.Show("Thành công"); LoadData(); }
            else { MessageBox.Show("Không thành công"); }
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _bhsv.GetAll(xeId).Count || rowIndex == -1) return;
            _id = Guid.Parse(dtg_show.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _bhsv.GetAll(xeId).FirstOrDefault(c => c.Id == _id);
            dtp_bd.Text = obj.NgayBatDau.ToString();
            dtp_kt.Text = obj.NgayKetThuc.ToString();
            tb_cp.Text = obj.ChiPhi.ToString();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var id = dtg_show.Rows[e.RowIndex].Cells["Id"].Value;

                if (id != null && Guid.TryParse(id.ToString(), out Guid bdid))
                {
                    _id = bdid;
                }
            }
            cb_lbh.Text = obj.LoaiBaoHiem.ToString();
        }
    }
}
