using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRenTal.View._4._QuanLyHoaDon
{
    public partial class QLHDDView : Form
    {
        int trangThai = 1;
        public QLHDDView()
        {
            InitializeComponent();
        }

        private void QLHDDView_Load(object sender, EventArgs e)
        {
            TimeSpan aInterval = new System.TimeSpan(45, 0, 0, 0);
            dtp_endDate.Value = DateTime.Now.Add(aInterval);
            dtp_endDate.MaxDate = DateTime.Now.Add(aInterval);
            dtp_endDate.MinDate = DateTime.Now;
            dtp_startDate.MinDate = DateTime.Now;
        }

        private void bt_datCoc_Click(object sender, EventArgs e)
        {
            SetColor();
            bt_datCoc.BackColor = Color.LightGray;
            trangThai = 1;
        }

        private void bt_dangThue_Click(object sender, EventArgs e)
        {
            SetColor();
            bt_dangThue.BackColor = Color.LightGray;
            trangThai = 2;
        }

        private void bt_hoanThanh_Click(object sender, EventArgs e)
        {
            SetColor();
            bt_hoanThanh.BackColor = Color.LightGray;
            trangThai = 3;
        }
        private void SetColor()
        {
            bt_datCoc.BackColor = Color.White;
            bt_dangThue.BackColor = Color.White;
            bt_hoanThanh.BackColor = Color.White;
        }
    }
}
