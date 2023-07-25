using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRenTal.View._5._QuanLyKhachHang
{
    public partial class TTKHchiTiet : Form
    {
        public QLKHView _QLKHView;
        public event EventHandler MyEvent;
        

        Guid _id = Guid.Empty;
        public TTKHchiTiet()
        {
            InitializeComponent();

        }
        public TTKHchiTiet(Guid id)
        {
            InitializeComponent();
            _id = id;
            
        }

        private void TTKHchiTiet_Load(object sender, EventArgs e)
        {
            MyEvent(this, EventArgs.Empty);

        }

        public void MyMethod(string data)
        {
            txtHoTenKH.Text = MyEvent.ToString();
        }
    }
}
