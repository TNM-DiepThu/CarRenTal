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
using System.Security.Policy;
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
        public KhachHang khachHangChon = new KhachHang();
        List<KhachHang> _lstKhachHang;
        public ChonKhachHangForm()
        {
            InitializeComponent();
        }


        private void ChonKhachHangForm_Load(object sender, EventArgs e)
        {
            SetUpCam();
            _lstKhachHang = choThueXeService.GetKhachHang("");
            LoadData();
        }
        #region SetUpCam quét QR
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

        private void SetUpCam()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filterInfoCollection)
            {
                cbb_chooseDrives.Items.Add(filter.Name);
            }
            cbb_chooseDrives.SelectedIndex = 2;
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
        #endregion
        void LoadData()
        {
            dtgv_data.Rows.Clear();
            dtgv_data.ColumnCount = 7;
            dtgv_data.Columns[0].HeaderText = "ID";
            dtgv_data.Columns[0].Visible = false;
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
                dtgv_data.Rows.Add(item.Id, item.Name, item.GioiTinh ? "Nam" : "Nữ", item.DiaChi, item.SDT, item.CCCD, item.NgaySinh);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            lb_idKH.Text = "";
            tx_cccdKH.Text = "";
            tx_nameKH.Text = "";
            tx_diaChiKH.Text = "";
            tx_cccdNT.Text = "";
            tx_nameNT.Text = "";
            tx_diaChiNT.Text = "";
            tx_sdtKH.Text = "";
            tx_sdtNT.Text = "";

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
            bool isNew = true;
            if (choThueXeService.FindByCCCD(tx_cccdKH.Text) != null)
            {
                isNew = false;
            }
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


            if (isNew)
            {
                if (choThueXeService.CreateKH(khachHang, nguoiThan))
                {
                    MessageBox.Show("Thành công");
                    khachHangChon = khachHang;
                    this.Close();
                }
            }
            else
            {

                if (choThueXeService.UpdateKH(khachHang, nguoiThan))
                {
                    MessageBox.Show("Thành công");
                    khachHangChon = khachHang;
                    this.Close();
                }
            }
        }

        private void dtgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_idKH.Text = dtgv_data.CurrentRow.Cells[0].Value.ToString();
            tx_nameKH.Text = dtgv_data.CurrentRow.Cells[1].Value.ToString();
            cbb_gtinhKH.SelectedIndex = dtgv_data.CurrentRow.Cells[2].Value.ToString() == "Nam" ? 0 : 1;
            tx_diaChiKH.Text = dtgv_data.CurrentRow.Cells[3].Value.ToString();
            tx_sdtKH.Text = dtgv_data.CurrentRow.Cells[4].Value.ToString();
            tx_cccdKH.Text = dtgv_data.CurrentRow.Cells[5].Value.ToString();
            dtp_ngaySinhKH.Value = DateTime.Parse(dtgv_data.CurrentRow.Cells[6].Value.ToString());
            ShowTN(lb_idKH.Text);

        }
        private void ShowTN(string id)
        {
            NguoiThan nguoiThan = choThueXeService.FindNTbyIdKH(Guid.Parse(id));

            tx_nameNT.Text = nguoiThan.Name.ToString();
            cbb_gtinhNT.SelectedIndex = nguoiThan.GioiTinh ? 0 : 1;
            tx_diaChiNT.Text = nguoiThan.DiaChi.ToString();
            tx_sdtNT.Text = nguoiThan.SDT.ToString();
            tx_cccdNT.Text = nguoiThan.CCCD.ToString();
        }

        private void tx_cccdKH_TextChanged(object sender, EventArgs e)
        {
            if (tx_cccdKH.Text.Length != 12)
            {
                return;
            }
            KhachHang khach = choThueXeService.FindByCCCD(tx_cccdKH.Text);
            if (lb_idKH.Text.Length < 10)
            {
                lb_idKH.Text = Guid.NewGuid().ToString();
            }
            if (khach != null && khach.Id != Guid.Parse(lb_idKH.Text))
            {
                var result = MessageBox.Show("Bạn có muốn tải lên!", "Đã có thông tin khách hàng này trong hệ thống", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    lb_idKH.Text = khach.Id.ToString();
                    tx_nameKH.Text = khach.Name.ToString();
                    cbb_gtinhKH.SelectedIndex = khach.GioiTinh ? 0 : 1;
                    tx_diaChiKH.Text = khach.DiaChi.ToString();
                    tx_sdtKH.Text = khach.SDT.ToString();
                    tx_cccdKH.Text = khach.CCCD.ToString();
                    dtp_ngaySinhKH.Value = khach.NgaySinh;
                    ShowTN(lb_idKH.Text);
                }
            }

        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            _lstKhachHang = choThueXeService.GetKhachHang(tx_search.Text);
            LoadData();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
