using Bus.Serviece.Implements;
using Dal.Modal;
using Dal.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRenTal.View._1.ChoThueXe
{
    public partial class ChoThueXeForm : Form
    {
        DateTime maxDate = DateTime.Now.AddDays(45);
        ChoThueXeService service = new ChoThueXeService();
        public ChoThueXeForm()
        {
            InitializeComponent();
            dtp_ngayThue.MinDate = DateTime.Now;
            dtp_ngayTra.MaxDate = maxDate;
            dtp_ngayTra.Value = maxDate;
        }

        public void LoadKhachHang(KhachHang khachHang)
        {
            if (khachHang == null) { return; }
            tx_nameKhach.Text = khachHang.Name;
            tx_canCuoc.Text = khachHang.CCCD;
        }

        private void ChoThueXeForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            cbb_hangXe.DataSource = service.GetHangXe();
            cbb_hangXe.DisplayMember = "Name";
            cbb_hangXe.ValueMember = "Id";
            cbb_nhienLieu.SelectedIndex = 0;
            cbb_soGhe.SelectedIndex = 0;
            cbb_hopSo.SelectedIndex = 0;
            cbb_hangXe.SelectedIndex = 0;
            cbb_trangThai.SelectedIndex = 0;
            dtgv_xeSS.Rows.Clear();
            dtgv_xeChon.Rows.Clear();
            dtgv_xeSS.ColumnCount = 8;
            dtgv_xeSS.Columns[0].HeaderText = "Tên xe";
            dtgv_xeSS.Columns[1].HeaderText = "Biển số";
            dtgv_xeSS.Columns[2].HeaderText = "Màu sắc";
            dtgv_xeSS.Columns[3].HeaderText = "Đơn giá";
            dtgv_xeSS.Columns[4].HeaderText = "Loại số xe";
            dtgv_xeSS.Columns[5].HeaderText = "Loại nhiên liệu";
            dtgv_xeSS.Columns[6].HeaderText = "Số ghế";
            dtgv_xeSS.Columns[7].HeaderText = "ID";
            dtgv_xeSS.Columns[7].Visible=false;
            dtgv_xeChon.ColumnCount = 9;
            dtgv_xeChon.Columns[0].HeaderText = "Tên xe";
            dtgv_xeChon.Columns[1].HeaderText = "Biển số";
            dtgv_xeChon.Columns[2].HeaderText = "Màu sắc";
            dtgv_xeChon.Columns[3].HeaderText = "Đơn giá";
            dtgv_xeChon.Columns[4].HeaderText = "Ngày bắt đầu";
            dtgv_xeChon.Columns[5].HeaderText = "Ngày kết thúc";
            dtgv_xeChon.Columns[6].HeaderText = "Số ngày";
            dtgv_xeChon.Columns[7].HeaderText = "Thành tiền";
            dtgv_xeChon.Columns[8].HeaderText = "ID";
            dtgv_xeChon.Columns[8].Visible=false;
        }

        private void bt_chooseCurtomer_Click(object sender, EventArgs e)
        {
            using (ChonKhachHangForm chonKhach = new ChonKhachHangForm())
            {
                if (chonKhach.ShowDialog() == DialogResult.OK)
                {
                    LoadKhachHang(chonKhach.khachHangChon);
                }
            };
        }


        private void bt_add_Click(object sender, EventArgs e)
        {
            TimeSpan interval = dtp_ngayTra.Value.Subtract(dtp_ngayThue.Value);
            MessageBox.Show("" + interval.Days);
            if (dtgv_xeSS.CurrentRow == null)
            {
                return;
            }
            dtgv_xeChon.Rows.Add(dtgv_xeSS.CurrentRow.Cells[0].Value.ToString(),
                                 dtgv_xeSS.CurrentRow.Cells[1].Value.ToString(),
                                 dtgv_xeSS.CurrentRow.Cells[2].Value.ToString(),
                                 dtgv_xeSS.CurrentRow.Cells[3].Value.ToString(),
                                 dtp_ngayThue.Value.Date.ToString(),
                                 dtp_ngayTra.Value.Date.ToString(),
                                 interval.Days.ToString(),
                                 int.Parse(dtgv_xeSS.CurrentRow.Cells[3].Value.ToString()) * interval.Days,
                                  dtgv_xeSS.CurrentRow.Cells[8].Value.ToString()
                                 );
        }


        void checkDate()
        {
            TimeSpan interval = dtp_ngayTra.Value.Subtract(dtp_ngayThue.Value);
            if (interval.Days < 0)
            {
                MessageBox.Show("Ngày mượn không thể cao hơn ngày trả");
            }
        }
        private void dtp_ngayThue_ValueChanged(object sender, EventArgs e)
        {
            checkDate();
        }

        private void dtp_ngayTra_ValueChanged(object sender, EventArgs e)
        {
            checkDate();
        }

        private void cbb_trangThai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbb_trangThai.SelectedIndex == 1)
            {
                
                gb_layXe.Visible = true;
            }
            else
            {
                gb_layXe.Visible = false;
            }
        }

        private void dt_delete_Click(object sender, EventArgs e)
        {
            if (dtgv_xeChon.CurrentRow == null)
            {
                return;
            }
            dtgv_xeChon.Rows.Remove(dtgv_xeChon.CurrentRow);
        }

        private void bt_deleteAll_Click(object sender, EventArgs e)
        {
            dtgv_xeChon.Rows.Clear();
        }
    }
}
