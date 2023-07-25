using Bus.Serviece.Implements;
using Bus.Serviece.Interface;
using Bus.ViewModal;
using Dal.Data;
using Dal.Modal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRenTal.View.QuanLiXe
{
    public partial class LoaiXeView : Form
    {
        CarRentalDBContext _context;
        Guid _id;
        ILoaiXeServiece _loaiXeServiece;
        IHangXeServiece _dshxe;      
        public LoaiXeView()
        {
            _context = new CarRentalDBContext();
            _loaiXeServiece = new LoaiXeServiece();
            _dshxe = new HangXeServiece();           
            InitializeComponent();
            cbb_hangxe.Items.Clear(); // Xóa các phần tử cũ (nếu có)
            foreach (var hangXe in _dshxe.GetAllHangXe())
            {
                cbb_hangxe.Items.Add(hangXe.Name);
            }
            LoadData();
        }
        private string GetTrangThaiAsString(int trangThai)
        {
            return trangThai == 0 ? "Hoạt động" : "Ngừng hoạt động";
        }

        private void LoadData()
        {
            //List<LoaiXe> danhSachLoaiXe = _loaiXeServiece.GetAll();
            int stt = 1;
            dtg_show.ColumnCount = 9;
            dtg_show.Columns[0].Name = "STT";
            dtg_show.Columns[1].Name = "Id";
            dtg_show.Columns[1].Visible = false;
            dtg_show.Columns[2].Name = "Tên Loại Xe";
            dtg_show.Columns[3].Name = "Loại nhiên liệu";
            dtg_show.Columns[4].Name = "Số ghế";
            dtg_show.Columns[5].Name = "Loại số xe";
            dtg_show.Columns[6].Name = "Nhiên liệu tiêu thụ";
            dtg_show.Columns[7].Name = "Hãng xe";
            dtg_show.Columns[8].Name = "Trạng Thái";
            dtg_show.Rows.Clear();
            foreach (var x in _loaiXeServiece.GetAll())
            {
                string trangThaiAsString = GetTrangThaiAsString(x.TrangThai);
                string tenHangXe = x.TenHangXe;
                dtg_show.Rows.Add(stt++, x.Id, x.Name, x.LoaiNguyenLieu, x.SoGhe, x.LoaiSoXe, x.NhienLieuTieuThu, tenHangXe, trangThaiAsString);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoaiXeView_Load(object sender, EventArgs e)
        {

        }
        //private LoaiXe GetDataFrom()
        //{


        //    return lxview;
        //}
        private void bt_add_Click(object sender, EventArgs e)
        {
            LoaiXe lxview = new LoaiXe();
            {
                lxview.Name = tb_name.Text;
                lxview.LoaiNguyenLieu = tb_lnl.Text;
                lxview.SoGhe = int.Parse(tb_soghe.Text);
                lxview.LoaiSoXe = tb_loaisoxe.Text;
                lxview.NhienLieuTieuThu = tb_nltt.Text;
                lxview.TrangThai = rd_0.Checked ? 1 : 0;

            };

            HangXe hangXe = _context.hangXes.FirstOrDefault(h => h.Name == cbb_hangxe.Text);
            if (hangXe != null)
            {
                lxview.IdHangXe = hangXe.Id;
                lxview.HangXe = hangXe;
            }
            _context.Add(lxview);
            _context.SaveChanges();
            _loaiXeServiece.Creat(lxview);
            // Hiển thị lại dữ liệu trên DataGridView
            LoadData();
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _loaiXeServiece.GetAll().Count || rowIndex == -1) return;
            _id = Guid.Parse(dtg_show.Rows[rowIndex].Cells[1].Value.ToString());
            var obj = _loaiXeServiece.GetAll().FirstOrDefault(c => c.Id == _id);
            tb_name.Text = obj.Name;
            tb_lnl.Text = obj.LoaiNguyenLieu;
            tb_soghe.Text = obj.SoGhe.ToString();
            tb_loaisoxe.Text = obj.LoaiSoXe;
            tb_nltt.Text = obj.NhienLieuTieuThu;


            rd_0.Checked = (obj.TrangThai == 0) ? true : false;
            rd_1.Checked = (obj.TrangThai != 0) ? true : false;


            var id = dtg_show.Rows[e.RowIndex].Cells["Id"].Value;

            // Kiểm tra xem giá trị Id có tồn tại và là Guid hợp lệ không
            if (id != null && Guid.TryParse(id.ToString(), out Guid hangXeId))
            {
                // Lưu Id vào biến tạm thời _id
                _id = hangXeId;

                // Tìm loại xe đã chọn và lấy tên hãng xe tương ứng
                var selectedLoaiXe = _loaiXeServiece.GetAll().FirstOrDefault(c => c.IdHang == _id);
                if (selectedLoaiXe != null)
                {
                    // Lấy tên hãng xe từ đối tượng LoaiXe đã chọn
                    string tenHangXe = selectedLoaiXe.TenHangXe;

                    // Đặt tên hãng xe vào ComboBox
                    cbb_hangxe.Text = tenHangXe;
                }
            }


            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
            //    // Lấy giá trị của cột Id từ cell được chọn
            //    var id = dtg_show.Rows[e.RowIndex].Cells["Id"].Value;

            //    // Kiểm tra xem giá trị Id có tồn tại và là Guid hợp lệ không
            //    if (id != null && Guid.TryParse(id.ToString(), out Guid hangXeId))
            //    {
            //        // Lưu Id vào biến tạm thời selectedHangXeId
            //        _id = hangXeId;
            //    }
            //}
        }

        private void cbb_hangxe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            if (_id != Guid.Empty)
            {
                // Hiển thị thông báo hỏi người dùng có đồng ý xóa hay không
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Người dùng đã đồng ý xóa, gọi phương thức xóa và kiểm tra kết quả
                    if (_loaiXeServiece.Delete(_id))
                    {
                        // Xóa thành công, cập nhật lại DataGridView
                        LoadData();
                        _id = Guid.Empty; // Đặt lại giá trị _id về mặc định
                    }
                    else
                    {
                        // Xóa không thành công, xử lý thông báo lỗi nếu cần
                        MessageBox.Show("Xóa không thành công. Hãy thử lại sau.");
                    }
                }
                // Người dùng không đồng ý xóa hoặc nhấn nút hủy, không thực hiện xóa.
            }
            else
            {
                // Không có dòng nào được chọn, thông báo cho người dùng chọn một dòng trước khi xóa (nếu cần).
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private LoaiXeVM GetDataFrom2()
        {
            LoaiXeVM view = new LoaiXeVM();
            {
                view.Id = _id; // _id là biến lưu giá trị Id của đối tượng LoaiXe được chọn trong DataGridView
                view.Name = tb_name.Text; // tb_name là TextBox chứa tên loại xe
                view.LoaiNguyenLieu = tb_lnl.Text; // tb_lnl là TextBox chứa loại nhiên liệu
                view.SoGhe = Int32.Parse(tb_soghe.Text); // tb_soghe là TextBox chứa số ghế (đã ép kiểu thành int)
                view.LoaiSoXe = tb_loaisoxe.Text; // tb_loaisoxe là TextBox chứa loại số xe
                view.NhienLieuTieuThu = tb_nltt.Text; // tb_nltt là TextBox chứa nhiên liệu tiêu thụ
                view.TenHangXe = cbb_hangxe.Text; // cbb_hangxe là ComboBox chứa Tên hãng xe
                view.TrangThai = rd_1.Checked ? 1 : 0; // rd_1 là RadioButton chứa Trạng thái (0: Hoạt động, 1: Ngừng hoạt động)
            }
            return view;
        }
        private void bt_edit_Click(object sender, EventArgs e)
        {
            var updatedData = GetDataFrom2();

            // Gọi phương thức cập nhật dữ liệu trong cơ sở dữ liệu
            if (_loaiXeServiece.Edit(updatedData))
            {
                // Cập nhật thành công, cập nhật lại DataGridView
                LoadData();
            }
            else
            {
                // Cập nhật không thành công, xử lý thông báo lỗi nếu cần
                MessageBox.Show("Cập nhật không thành công. Hãy thử lại sau.");
            }
        }
    }
}
