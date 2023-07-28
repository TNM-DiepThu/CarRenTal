using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRenTal.View._4.QuanLyHoaDon
{
    public partial class HoaDonDaCoc : Form
    {
        public HoaDonDaCoc()
        {
            InitializeComponent();
        }

        private void HoaDonDaCoc_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void LoadData()
        {
            TimeSpan aInterval = new System.TimeSpan(45, 0, 0, 0);
            dtp_endDate.Value = DateTime.Now.Add(aInterval);
            dtp_endDate.MaxDate = DateTime.Now.Add(aInterval);
            dtp_endDate.MinDate = DateTime.Now;
            dtp_startDate.MinDate = DateTime.Now;

        }
    }
}
