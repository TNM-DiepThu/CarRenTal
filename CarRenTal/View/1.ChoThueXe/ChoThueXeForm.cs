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
        DateTime maxDate= DateTime.Now.AddDays(45);
        public ChoThueXeForm()
        {
            InitializeComponent();
            dtp_ngayTra.MaxDate = maxDate;
            dtp_ngayTra.Value = maxDate;
        }



        private void ChoThueXeForm_Load(object sender, EventArgs e)
        {
            
        }


    }
}
