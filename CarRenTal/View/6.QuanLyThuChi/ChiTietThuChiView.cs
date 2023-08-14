using Bus.Serviece.Implements;
using Bus.ViewModal;
using Dal.Modal;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = Microsoft.Office.Interop.Excel.DataTable;
using Excel = Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace CarRenTal.View._6.QuanLyThuChi
{
    public partial class ChiTietThuChiView : Form
    {
        HoaDonChiTietService _HDCTService = new HoaDonChiTietService();
        List<HoaDonChiTiet> _lstHDCT;
        List<HoaDonThueXe> _LstHDTX;
        List<ChiPhiPhatSinh> _lstPhatSinh;
        XeService _xeService = new XeService();
        List<Xe> _lstXe;
        List<LoaiXe> _lstLoaiXe;
        List<ChiPhiPhatSinh> _lstCPPS;
        List<XeBaoHiem> _lstXeBaoHiem;
        List<DangKiem> _lstDangKiem;
        List<BaoDuong> _lstBaoDuong;
        decimal _tongTien = 0;
        decimal _tongChi = 0;


        KhoanChiService _KhoanChiService = new KhoanChiService();
        DoanhThuService _doanhThuService = new DoanhThuService();
        List<KhoanChi> _lstKhoanChi;
        List<DoanhThu> _lstDoanhThu;
        public ChiTietThuChiView()
        {
            InitializeComponent();
            _lstHDCT = new List<HoaDonChiTiet>();
            _lstXe = new List<Xe>();
            _lstBaoDuong = new List<BaoDuong>();
            _lstXeBaoHiem = new List<XeBaoHiem>();
            _lstDangKiem = new List<DangKiem>();
            _lstCPPS = new List<ChiPhiPhatSinh>();
            _lstKhoanChi = new List<KhoanChi>();
            _lstDoanhThu = new List<DoanhThu>();
            _lstPhatSinh = new List<ChiPhiPhatSinh>();
            _LstHDTX = new List<HoaDonThueXe>();
            LoadDLDoanhThu(dtTimeSearch.Value);
            LoadLoaiChi(dtTimeSearch.Value);
            TinhDoanhThu();
        }

        public void ChiTietThuChiView_Load(object sender, EventArgs e)
        {

        }

        public void LoadDLDoanhThu(DateTime dtBD)
        {
            dgvDoanhThu.Rows.Clear();

            dgvDoanhThu.ColumnCount = 12;

            dgvDoanhThu.Columns[0].Name = "Số hợp đồng";
            dgvDoanhThu.Columns[1].Name = "Tên xe";
            dgvDoanhThu.Columns[2].Name = "Biển số";
            dgvDoanhThu.Columns[3].Name = "Ngày bắt đầu";
            dgvDoanhThu.Columns[4].Name = "Ngày kết thúc";
            dgvDoanhThu.Columns[5].Name = "Số ngày";
            dgvDoanhThu.Columns[6].Name = "Đơn giá";
            dgvDoanhThu.Columns[7].Name = "Tiền cọc";
            dgvDoanhThu.Columns[8].Name = "Phụ phí";
            dgvDoanhThu.Columns[9].Name = "Số tiền cần thu";
            dgvDoanhThu.Columns[10].Name = "Tổng tiền";
            dgvDoanhThu.Columns[11].Name = "Nhân viên thực hiện";
            _lstDoanhThu = _doanhThuService.GetDoanhThus(dtBD);
            foreach (var i in _lstDoanhThu.Where(c => c.ngayBD.Date == dtBD))
            {
                dgvDoanhThu.Rows.Add(i.maHD, i.tenXe, i.bienSo, i.ngayBD, i.ngayKT, (i.ngayKT - i.ngayBD).Days, i.donGia, i.tienCoc, i.phuPhi, (i.tongTien - i.tienCoc) + i.phuPhi, i.tongTien, i.tenNV);
            }
        }
        public void LoadLoaiChi(DateTime dtBD)
        {
            dgvKhoanChi.Rows.Clear();

            dgvKhoanChi.ColumnCount = 5;

            dgvKhoanChi.Columns[0].Name = "Loại chi";
            dgvKhoanChi.Columns[1].Name = "Số tiền";
            dgvKhoanChi.Columns[2].Name = "Ngày chi";
            dgvKhoanChi.Columns[3].Name = "Xe";
            dgvKhoanChi.Columns[4].Name = "Biển số";
            //dgvKhoanChi.Columns[5].Name = "Chi tiết";

            _lstKhoanChi = _KhoanChiService.GetKhoanChi(dtTimeSearch.Value.Date);
            foreach (var i in _lstKhoanChi)
            {
                dgvKhoanChi.Rows.Add(i.loaiChi, i.soTien, i.ngayChi, i.loaiXe, i.bienSo);
            }
        }
        private void dgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void dtTimeSearch_ValueChanged(object sender, EventArgs e)
        {
            LoadDLDoanhThu(dtTimeSearch.Value);
            LoadLoaiChi(dtTimeSearch.Value);
            TinhDoanhThu();
        }

        private void TinhDoanhThu()
        {
            if (dgvDoanhThu.Rows.Count == 0)
            {
                lbDoanhThu.Text = 0.ToString();
            }
            if (dgvKhoanChi.Rows.Count == 0)
            {
                lbChi.Text = 0.ToString();
            }

            _tongTien = 0;
            for (int i = 0; i < dgvDoanhThu.Rows.Count; i++)
            {
                _tongTien += (decimal)dgvDoanhThu.Rows[i].Cells[10].Value;

                lbDoanhThu.Text = _tongTien.ToString();
            }
            _tongChi = 0;
            for (int i = 0; i < dgvKhoanChi.Rows.Count; i++)
            {
                _tongChi += (decimal)dgvKhoanChi.Rows[i].Cells[1].Value;

                lbChi.Text = _tongChi.ToString();
            }
        }


        private void lbDoanhThu_TextChanged(object sender, EventArgs e)
        {
            lbLoiNhuan.Text = (int.Parse(lbDoanhThu.Text) - int.Parse(lbChi.Text)).ToString();
        }

        public void FindXe(string tenXe)
        {
            if (tenXe == "")
            {
                MessageBox.Show("Bạn chưa nhập liệu");
            }

            dgvDoanhThu.Rows.Clear();

            dgvDoanhThu.ColumnCount = 12;

            dgvDoanhThu.Columns[0].Name = "Số hợp đồng";
            dgvDoanhThu.Columns[1].Name = "Tên xe";
            dgvDoanhThu.Columns[2].Name = "Biển số";
            dgvDoanhThu.Columns[3].Name = "Ngày bắt đầu";
            dgvDoanhThu.Columns[4].Name = "Ngày kết thúc";
            dgvDoanhThu.Columns[5].Name = "Số ngày";
            dgvDoanhThu.Columns[6].Name = "Đơn giá";
            dgvDoanhThu.Columns[7].Name = "Tiền cọc";
            dgvDoanhThu.Columns[8].Name = "Phụ phí";
            dgvDoanhThu.Columns[9].Name = "Số tiền cần thu";
            dgvDoanhThu.Columns[10].Name = "Tổng tiền";
            dgvDoanhThu.Columns[11].Name = "Nhân viên thực hiện";
            _lstDoanhThu = _doanhThuService.GetDoanhThus(dtTimeSearch.Value.Date);
            foreach (var i in _lstDoanhThu.Where(c => c.tenXe.ToLower().Contains(txtSearch.Text.ToLower())))
            {
                dgvDoanhThu.Rows.Add(i.maHD, i.tenXe, i.bienSo, i.ngayBD, i.ngayKT, (i.ngayKT - i.ngayBD).Days, i.donGia, i.tienCoc, i.phuPhi, (i.tongTien - i.tienCoc) + i.phuPhi, i.tongTien, i.tenNV);
            }

            dgvKhoanChi.Rows.Clear();

            dgvKhoanChi.ColumnCount = 5;

            dgvKhoanChi.Columns[0].Name = "Loại chi";
            dgvKhoanChi.Columns[1].Name = "Số tiền";
            dgvKhoanChi.Columns[2].Name = "Ngày chi";
            dgvKhoanChi.Columns[3].Name = "xe";
            dgvKhoanChi.Columns[4].Name = "Biển số";
            //dgvKhoanChi.Columns[5].Name = "Chi tiết";

            _lstKhoanChi = _KhoanChiService.GetKhoanChi(dtTimeSearch.Value.Date);
            foreach (var i in _lstKhoanChi.Where(c => c.loaiXe.ToLower().Contains(txtSearch.Text.ToLower())))
            {
                dgvKhoanChi.Rows.Add(i.loaiChi, i.soTien, i.ngayChi, i.loaiXe, i.bienSo);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindXe(txtSearch.Text);
            TinhDoanhThu();
        }

        private void btnXuatDL_Click(object sender, EventArgs e)
        {
            //string filePath = "";
            //SaveFileDialog dialog = new SaveFileDialog();
            //dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    filePath = dialog.FileName;
            //}
            //export2Excel(dgvDoanhThu, filePath);
            if (dgvDoanhThu.Rows.Count != 0)
            {
                XuatExcelDoanhThu(dgvDoanhThu, "Doanh thu", "Doanh thu ngày " + dtTimeSearch.Value.ToString());
            }
            else
            {
                MessageBox.Show("Không có dữ liệu");
                return;
            }


        }
        //private void export2Excel(DataGridView g, string duongDan)
        //{
        //    app obj = new app();
        //    obj.Application.Workbooks.Add(Type.Missing);
        //    obj.Columns.ColumnWidth = 25;
        //    for (int i = 2; i < g.Columns.Count; i++) { obj.Cells[1, i - 1] = g.Columns[i].HeaderText; }
        //    for (int i = 0; i < g.Rows.Count; i++)
        //    {
        //        for (int j = 2; j < g.Columns.Count; j++)
        //        {
        //            if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j - 1] = g.Rows[i].Cells[j].Value.ToString(); }
        //        }
        //    }
        //    //  obj.ActiveWorkbook.SaveCopyAs(duongDan + ".xlsx");
        //    obj.ActiveWorkbook.SaveAs(duongDan);
        //    obj.ActiveWorkbook.Saved = true;
        //}
        public void XuatExcelDoanhThu(DataGridView dtTB, string sheetName, string title)
        {
            // Tạo các đối tượng Excel
            Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel workBook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;
            //Tạo tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "L1");

            // truyền data
            for (int i = 0; i < dtTB.Rows.Count; i++)
            {
                for (int j = 0; j < dtTB.Columns.Count; j++)
                {
                    if (dtTB.Rows[i].Cells[j].Value != null) { oExcel.Cells[i + 4, j + 1] = dtTB.Rows[i].Cells[j].Value.ToString(); }
                }
            }


            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Creat title columns

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Số hợp đồng";
            cl1.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên xe";
            cl2.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Biển số";
            cl3.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Ngày bắt đầu";
            cl4.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Ngày kết thúc";
            cl5.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Số ngày";
            cl6.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Đơn giá";
            cl7.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Tiền cọc";
            cl8.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Phụ phí";
            cl9.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "Số tiền cần thu";
            cl10.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");
            cl11.Value2 = "Tổng tiền";
            cl11.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl12 = oSheet.get_Range("L3", "L3");
            cl12.Value2 = "Nhân viên thực hiện";
            cl12.ColumnWidth = 20;


            // Xác định hàng tiêu đề
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "L3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            // In danh sach chi tiet 
            //int stt = 4;
            //for (int i = 0; i < dgvDoanhThu.Rows.Count - 1; i++)
            //{
            //    oSheet.Range["A" + (stt + i).ToString()].Value = dgvDoanhThu.Rows[i].Cells.ToString();
            //    oSheet.Range["B" + (stt + i).ToString()].Value = dgvDoanhThu.Rows[i].Cells.ToString();
            //}
            //stt = stt + dtTB.Rows.Count;
            //for (int i = 2; i < dtTB.Columns.Count; i++) { oExcel.Cells[1, i - 1] = dtTB.Columns[i].HeaderText; }


            ////Lưu file
            //SaveFileDialog save = new SaveFileDialog();
            //if (save.ShowDialog()==DialogResult.OK )
            //{
            //    oBook.SaveAs2(save.FileName.ToLower()+".xls");
            //    MessageBox.Show("Bạn đã lưu thành công");
            //}
            //oExcel.Quit();
            // Tạo mảng theo  databable

            //object[,] arr = new object[dgvDoanhThu.Rows.Count, dgvDoanhThu.Columns.Count];
            ////Chuyển dữ liệu từ DataGridView vào mảng đối tượng
            //for (int row = 1; row < dgvDoanhThu.Rows.Count; row++)
            //{
            //    DataGridViewRow dtRow = dgvDoanhThu.Rows[row];
            //    for (int col = 0; col < dgvDoanhThu.Columns.Count; col++)
            //    {
            //        arr[row, col] = dtRow.Cells[col].Value;
            //    }
            //}

            //// Thiết lập vùng điền dữ liệu
            //int rowStart = 4;
            //int columnStart = 1;

            //int rowEnd = rowStart + dgvDoanhThu.Rows.Count - 1;

            //int columnEnd = dgvDoanhThu.Columns.Count;

            ////Ô bắt đầu điền dữ liệu
            //Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            //// Ô kết thúc điền dữ liệu

            //Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            //// Lấy về vùng điền dữ liệu

            //Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);


            ////Điền dữ liệu vào vùng đã thiết lập

            //range.Value2 = arr;

            //// Kẻ viền

            //range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            //// Căn giữa cột 

            ////Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];


            ////Căn giữa cả bảng 
            ////oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            ////dgvDoanhThu.Columns[0].Name = "Mã HD";
            ////dgvDoanhThu.Columns[1].Name = "Tên xe";
            ////dgvDoanhThu.Columns[2].Name = "Biển số";
            ////dgvDoanhThu.Columns[3].Name = "Ngày bắt đầu";
            ////dgvDoanhThu.Columns[4].Name = "Ngày kết thúc";
            ////dgvDoanhThu.Columns[5].Name = "Số ngày";
            ////dgvDoanhThu.Columns[6].Name = "Đơn giá";
            ////dgvDoanhThu.Columns[7].Name = "Phụ phí";
            ////dgvDoanhThu.Columns[8].Name = "Tổng tiền";
        }

        public void XuatExcelKhoanChi(DataGridView dtTB, string sheetName, string title)
        {
            // Tạo các đối tượng Excel
            Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel workBook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;
            //Tạo tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "E1");

            // truyền data
            for (int i = 0; i < dtTB.Rows.Count; i++)
            {
                for (int j = 0; j < dtTB.Columns.Count; j++)
                {
                    if (dtTB.Rows[i].Cells[j].Value != null) { oExcel.Cells[i + 4, j + 1] = dtTB.Rows[i].Cells[j].Value.ToString(); }
                }
            }

            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Creat title columns

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Loại chi";
            cl1.ColumnWidth = 30;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Số tiền";
            cl2.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Ngày chi";
            cl3.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Xe";
            cl4.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Biển số";
            cl5.ColumnWidth = 20;

            // Xác định hàng tiêu đề
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            ////Lưu file
            //SaveFileDialog save = new SaveFileDialog();
            //if (save.ShowDialog()==DialogResult.OK )
            //{
            //    oBook.SaveAs2(save.FileName.ToLower()+".xls");
            //    MessageBox.Show("Bạn đã lưu thành công");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvKhoanChi.Rows.Count != 0)
            {
                XuatExcelKhoanChi(dgvKhoanChi, "Khoan chi", "Danh sách Khoản chi " + dtTimeSearch.Value.ToString());
            }
            else
            {
                MessageBox.Show("Không có dữ liệu");
                return;
            }

        }
    }
}
