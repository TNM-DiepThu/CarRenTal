using AForge.Video;
using AForge.Video.DirectShow;
using Bus.Serviece.Implements;
using Dal.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace CarRenTal.View._1.ChoThueXe
{
    public partial class ChonKhachHangForm : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice finalFrame = new VideoCaptureDevice();
        int currenInfor = 0;
        ChoThueXeService choThueXeService = new ChoThueXeService();
        KhachHang khachHangChon = new KhachHang();
        List<KhachHang> _lstKhachHang;
        public ChonKhachHangForm()
        {
            InitializeComponent();
        }

        private void CurentInfo(int button)
        {
            if (button == currenInfor)
            {
                currenInfor = 0;
                bt_start.Enabled = false;
                return;
            }
            currenInfor = button;
            bt_start.Enabled = true;

        }
        private void ChonKhachHangForm_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filterInfoCollection)
            {
                cbb_chooseDrives.Items.Add(filter.Name);
            }
            cbb_chooseDrives.SelectedIndex = 2;
            _lstKhachHang = choThueXeService.GetKhachHang("");
            LoadData();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            bt_start.Enabled = false;
            bt_stop.Enabled = true;
            finalFrame = new VideoCaptureDevice(filterInfoCollection[cbb_chooseDrives.SelectedIndex].MonikerString);
            finalFrame.NewFrame += new NewFrameEventHandler(finalFrame_NewFrame);
            finalFrame.Start();
        }
        private void finalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pic_Cam.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void ChonKhachHangForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (finalFrame.IsRunning)
            {
                //           finalFrame.Stop();
                finalFrame.SignalToStop();
                finalFrame.WaitForStop();
            }
        }
        void ScanQR()
        {
            var reader = new BarcodeReaderGeneric();

            Bitmap img = (Bitmap)pic_Cam.Image;
            if (img != null)
            {
                try
                {
                    LuminanceSource source;
                    source = new ZXing.Windows.Compatibility.BitmapLuminanceSource(img);
                    Result result = reader.Decode(source);

                    if (result != null)
                    {
                        string[] codeText = result.Text.Split('|');
                        if (currenInfor == 1)
                        {
                            tx_cccdKH.Text = codeText[0];
                            tx_nameKH.Text = codeText[2];
                            string day = codeText[3][0] + codeText[3][1].ToString();
                            string date = (day + "/" + codeText[3][2] + codeText[3][3] + "/" + codeText[3][4] + codeText[3][5] + codeText[3][6] + codeText[3][7]).ToString();
                            dtp_ngaySinhKH.Value = DateTime.ParseExact(date, "dd/MM/yyyy", null);
                            cbb_gtinhKH.SelectedIndex = codeText[4] == "Nam" ? 0 : 1;
                            tx_diaChiKH.Text = codeText[5];
                        }
                        else
                        {
                            tx_cccdNT.Text = codeText[0];
                            tx_nameNT.Text = codeText[2];
                            string day = codeText[3][0] + codeText[3][1].ToString();
                            cbb_gtinhNT.SelectedIndex = codeText[4] == "Nam" ? 0 : 1;
                            tx_diaChiNT.Text = codeText[5];
                        }
                    }
                }
                catch (Exception)
                {
                    ;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ScanQR();
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            pic_Cam.Image = null;
            if (finalFrame.IsRunning)
            {
                //           finalFrame.Stop();
                bt_start.Enabled = true;
                bt_stop.Enabled = false;
                finalFrame.SignalToStop();
                finalFrame.WaitForStop();
            }
        }
        void LoadData()
        {
            dtgv_data.Rows.Clear();
            dtgv_data.ColumnCount = 7;
            dtgv_data.Columns[0].HeaderText = "ID";
            dtgv_data.Columns[1].HeaderText = "Họ và tên";
            dtgv_data.Columns[2].HeaderText = "Giới tính";
            dtgv_data.Columns[3].HeaderText = "Địa chỉ";
            dtgv_data.Columns[4].HeaderText = "SDT";
            dtgv_data.Columns[5].HeaderText = "CCCD";
            dtgv_data.Columns[6].HeaderText = "Ngày sinh";

            if (_lstKhachHang == null)
            {
                return;
            }
            foreach (var item in _lstKhachHang)
            {
                dtgv_data.Rows.Add(item.Id, item.Name, item.GioiTinh, item.DiaChi, item.SDT, item.CCCD, item.NgaySinh);
            }
        }
        private void bt_khach_Click(object sender, EventArgs e)
        {
            CurentInfo(1);
            if (currenInfor == 1)
            {
                bt_khach.BackColor = Color.LightGray;
                bt_nguoiThan.BackColor = Color.White;
            }
            else
            {
                bt_khach.BackColor = Color.White;
            }
        }

        private void bt_nguoiThan_Click(object sender, EventArgs e)
        {
            CurentInfo(2);
            if (currenInfor == 2)
            {
                bt_khach.BackColor = Color.White;
                bt_nguoiThan.BackColor = Color.LightGray;
            }
            else
            {
                bt_nguoiThan.BackColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_cccdKH.Text = "";
            tx_nameKH.Text = "";
            tx_diaChiKH.Text = "";
            tx_cccdNT.Text = "";
            tx_nameNT.Text = "";
            tx_diaChiNT.Text = "";
        }
        string checkInfor()
        {
            if (tx_nameKH.Text.Length == 0 || cbb_gtinhKH.SelectedIndex < 0 || tx_diaChiKH.Text.Length == 0 ||
         tx_nameNT.Text.Length == 0 || cbb_gtinhNT.SelectedIndex < 0 || tx_diaChiNT.Text.Length == 0)
            {
                return "Không được bỏ trống thông tin";
            }
            // regex tên
            string paramater = @"^[AÀẢÃÁẠĂẰẲẴẮẶÂẦẨẪẤẬBCDĐEÈẺẼÉẸÊỀỂỄẾỆFGHIÌỈĨÍỊJKLMNOÒỎÕÓỌÔỒỔỖỐỘƠỜỞỠỚỢPQRSTUÙỦŨÚỤƯỪỬỮỨỰVWXYỲỶỸÝỴZ][aàảãáạăằẳẵắặâầẩẫấậbcdđeèẻẽéẹêềểễếệfghiìỉĩíịjklmnoòỏõóọôồổỗốộơờởỡớợpqrstuùủũúụưừửữứựvwxyỳỷỹýỵz]+ [AÀẢÃÁẠĂẰẲẴẮẶÂẦẨẪẤẬBCDĐEÈẺẼÉẸÊỀỂỄẾỆFGHIÌỈĨÍỊJKLMNOÒỎÕÓỌÔỒỔỖỐỘƠỜỞỠỚỢPQRSTUÙỦŨÚỤƯỪỬỮỨỰVWXYỲỶỸÝỴZ][aàảãáạăằẳẵắặâầẩẫấậbcdđeèẻẽéẹêềểễếệfghiìỉĩíịjklmnoòỏõóọôồổỗốộơờởỡớợpqrstuùủũúụưừửữứựvwxyỳỷỹýỵz]+(?: [AÀẢÃÁẠĂẰẲẴẮẶÂẦẨẪẤẬBCDĐEÈẺẼÉẸÊỀỂỄẾỆFGHIÌỈĨÍỊJKLMNOÒỎÕÓỌÔỒỔỖỐỘƠỜỞỠỚỢPQRSTUÙỦŨÚỤƯỪỬỮỨỰVWXYỲỶỸÝỴZ][aàảãáạăằẳẵắặâầẩẫấậbcdđeèẻẽéẹêềểễếệfghiìỉĩíịjklmnoòỏõóọôồổỗốộơờởỡớợpqrstuùủũúụưừửữứựvwxyỳỷỹýỵz]*)*";
            Regex regex = new Regex(paramater);
            if (!regex.IsMatch(tx_nameKH.Text))
            {
                return "Họ tên khách hàng không hợp lệ";
            }

            if (!regex.IsMatch(tx_nameNT.Text))
            {
                return "Họ tên người thân không hợp lệ";
            }
            //regex giới tính
            if ((cbb_gtinhNT.SelectedIndex != 1 && cbb_gtinhNT.SelectedIndex != 0) || (cbb_gtinhKH.SelectedIndex != 1 && cbb_gtinhKH.SelectedIndex != 0))
            {
                return "Giới tính không hợp lệ";
            }
            //regex số điện thoại
            paramater = @"0(3\d{8}|9\d{8}|8\d{8}|5\d{8}|7\d{8})";
            regex = new Regex(paramater);
            if (!regex.IsMatch(tx_sdtKH.Text))
            {
                return "Số điện thoại khách hàng không hợp lệ";
            }
            if (!regex.IsMatch(tx_sdtNT.Text))
            {
                return "Số điện thoại khách hàng không hợp lệ";
            }
            return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string check = checkInfor();
            if (check != null)
            {
                MessageBox.Show("" + check);
                return;
            }
            KhachHang khachHang = new KhachHang()
            {
                Id = Guid.NewGuid(),
                Name = tx_nameKH.Text,
                GioiTinh = cbb_gtinhKH.SelectedIndex == 1 ? false : true,
                DiaChi = tx_diaChiKH.Text,
                CCCD = tx_cccdKH.Text,
                NgaySinh = dtp_ngaySinhKH.Value,
                SDT = tx_sdtKH.Text,

            };
            NguoiThan nguoiThan = new NguoiThan()
            {
                Id = Guid.NewGuid(),
                Name = tx_nameNT.Text,
                GioiTinh = cbb_gtinhNT.SelectedIndex == 1 ? false : true,
                DiaChi = tx_diaChiNT.Text,
                CCCD = tx_cccdNT.Text,
                SDT = tx_sdtNT.Text,
                IdKhachHang = khachHang.Id,
            };

            if (choThueXeService.CreateKH(khachHang, nguoiThan))
            {
                MessageBox.Show("thành công");
            }
        }
    }
}
