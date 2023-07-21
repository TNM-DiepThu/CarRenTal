using Bus.Serviece.Implements;
using Bus.Serviece.Interface;
using Dal.Data;
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

namespace CarRenTal.View
{
    
    public partial class HangXeView : Form
    {

        IHangXeServiece _hangXeServiece;
        public HangXeView()
        {
           _hangXeServiece = new HangXeServiece();
            InitializeComponent();
            DataLoad();

        }
        private void DataLoad()
        {
            int stt = 1;
            ShowHangXe.ColumnCount = 4;
            ShowHangXe.Columns[0].Name = "STT";
            ShowHangXe.Columns[1].Name = "Id";
            ShowHangXe.Columns[1].Visible = false;
            ShowHangXe.Columns[2].Name = "Name";
            ShowHangXe.Columns[3].Name = "TrangThai";
            ShowHangXe.Rows.Clear();
            foreach (var x in _hangXeServiece.GetAllHangXe())
            {
                ShowHangXe.Rows.Add(stt++, x.Id, x.Name, x.TrangThai);
            }


        }
    }
}
