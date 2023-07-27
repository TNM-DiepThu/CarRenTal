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
        public ChoThueXeForm()
        {
            InitializeComponent();
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

        }

        private void bt_chooseCurtomer_Click(object sender, EventArgs e)
        {
            using (ChonKhachHangForm chonKhach = new ChonKhachHangForm())
            {
                if (chonKhach.ShowDialog()==DialogResult.OK)
                {
                    LoadKhachHang(chonKhach.khachHangChon);
                }
            } ;
        }
    }
}
