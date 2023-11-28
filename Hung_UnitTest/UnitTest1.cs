
using System.Reflection;
using System.Windows.Forms;
using CarRenTal.View._1.ChoThueXe;
using Dal.Modal;
using Dal.Repository;
using Moq;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Hung_UnitTest
{
	public class Tests
	{
		public ChoThueXeForm frm;
		XeRepo xeRepo = new XeRepo();
		HoaDonChiTietRepo hoaDonChiTietRepo = new HoaDonChiTietRepo();
		BaoDuongRepo baoDuongRepo = new BaoDuongRepo();
		TaiSanTheChapRepo taiSanRepo= new TaiSanTheChapRepo();
		HangXeRepo hangXeRepo = new HangXeRepo();
		LoaiXeRepo loaiXeRepo = new LoaiXeRepo();	
		KhachHangRepo khachHangRepo = new KhachHangRepo();
		NguoiThanRepo nguoiThanRepo = new NguoiThanRepo();
		DangKiemRepo dangKiemRepo = new DangKiemRepo();
		GiayToTheChapRepo giayToRepo= new GiayToTheChapRepo();
		MauSacRepo mauSacRepo = new MauSacRepo();
		HoaDonThueXeRepo hoaDonRepo = new HoaDonThueXeRepo();
		TheChapRepo theChapRepo = new TheChapRepo();
		List<Xe> lstXe;
		List<HoaDonChiTiet> lstHoaDonChitiet;
		List<BaoDuong> lstBaoDuong;
		List<HangXe> lstHangXe;
		List<LoaiXe> lstLoaiXe;
		List<GiayToTheChap> lstGiayToTheChap;
		List<TaiSanTheChap> lstTaiSan;
		List<KhachHang> lstKhachHang;
		List<NguoiThan> lstNguoiThan;
		List<DangKiem> lstDangKiem;
		List<Xe> list1;
	
		[SetUp]
		public void Setup()
		{
			frm = new ChoThueXeForm(new Dal.Modal.NhanVien() { Id = Guid.Parse("BC8C0A62-8157-475F-BB06-598569ACE162") });
			frm.ChoThueXeForm_Load(null, null);
			lstXe = xeRepo.GetXe();
			lstHoaDonChitiet = hoaDonChiTietRepo.GetALL();
			lstBaoDuong = baoDuongRepo.GetALL();			
			lstHangXe = hangXeRepo.GetALL();
			lstLoaiXe = loaiXeRepo.GetALL();
			lstTaiSan = taiSanRepo.GetALL();
			lstGiayToTheChap = giayToRepo.GetALL();
			lstKhachHang = khachHangRepo.GetALL();
			lstNguoiThan = nguoiThanRepo.GetALL();
			lstDangKiem = dangKiemRepo.GetALL();
			list1 = GetXe(frm.dtp_ngayThue.Value.Date, frm.dtp_ngayTra.Value.Date, frm.lstXeChon);
			
		}
		//Test 1 load xe thành công lên form từ db
		[Test]
		public void TC_U_01()
		{
		
			var list2 = frm.lstXeTest;
			bool result = true;
			for (int i = 0; i < list1.Count; i++)
			{

				if (list1.OrderBy(p => p.ID).ToList()[i].ID == (list2.OrderBy(p => p.ID).ToList()[i]).ID)
				{
					continue;
				}
				result = false;
			}

			Assert.IsTrue(result);
		}

		public List<Xe> GetXe(DateTime startDate, DateTime endDate, List<HoaDonChiTiet> xeDaChon)
		{
			if (startDate.Date > endDate)
			{
				return new List<Xe>();
			}
			List<Xe> result = xeRepo.GetXe();
			// Loại xe đã chọn
			var checkDK = from xe in lstXe
						  join hd in xeDaChon on xe.ID equals hd.IdXe
						  where (((startDate >= hd.NgayBatDau && startDate <= hd.NgayKetThuc) || (endDate >= hd.NgayBatDau && endDate <= hd.NgayKetThuc)))
						  select xe;
			if (checkDK != null && result != null)
			{
				result.RemoveAll(r => checkDK.Any(a => a.ID == r.ID));
			}
			//kiểm tra đăng kiểm
			checkDK = from xe in lstXe
					  join dk in lstDangKiem on xe.ID equals dk.IdXe
					  where dk.NgayHetHan < endDate
					  select xe;

			if (checkDK != null && result != null)
			{
				result.RemoveAll(r => checkDK.Any(a => a.ID == r.ID));
			}
			//kiểm tra xe có đang cho thuê hay không
			checkDK = from xe in lstXe
					  join hd in lstHoaDonChitiet on xe.ID equals hd.IdXe
					  where (((startDate >= hd.NgayBatDau && startDate <= hd.NgayKetThuc) || (endDate >= hd.NgayBatDau && endDate <= hd.NgayKetThuc || (startDate <= hd.NgayBatDau && endDate >= hd.NgayKetThuc))) && (hd.TrangThai == 2 || hd.TrangThai == 1))
					  select xe;
			if (checkDK != null && result != null)
			{
				result.RemoveAll(r => checkDK.Any(a => a.ID == r.ID));
			}
			//kiểm tra xe có đang bảo dưỡng hay không
			checkDK = from xe in lstXe
					  join bd in lstBaoDuong on xe.ID equals bd.IdXe
					  where bd.TrangThai == 1
					  select xe;
			if (checkDK != null && result != null)
			{
				result.RemoveAll(r => checkDK.Any(a => a.ID == r.ID));
			}
			//kiểm tra xe  hoạt động
			checkDK = from xe in lstXe
					  where xe.TrangThai != 1
					  select xe;

			if (checkDK != null && result != null)
			{
				result.RemoveAll(r => checkDK.Any(a => a.ID == r.ID));
			}

			if (result == null)
			{
				return result;
			}
			foreach (var item in result)
			{
				item.MauSac = mauSacRepo.GetALL().FirstOrDefault(p => p.Id == item.IdMauSac);
				item.LoaiXe = lstLoaiXe.FirstOrDefault(p => p.Id == item.IdLoaiXe);
				item.LoaiXe.HangXe = lstHangXe.FirstOrDefault(p => p.Id == item.LoaiXe.IdHangXe);
			}
			return result.ToList();
		}

		//Test2 tìm kiếm thành công xe theo tên 
		[Test]
		public void TC_U_02()
		{
			
			frm.tx_search.Text = "CX-5";

			frm.bt_search_Click(null, null);
			var list2 = frm.lstXeTest;
			bool result = true;
			List<Xe> lstXe2 = list1;		
				lstXe2 = lstXe2.Where(p => p.LoaiXe.Name.ToLower().Contains("CX-5".ToLower()) || p.LoaiXe.HangXe.Name.ToLower().Contains("CX-5".ToLower())).ToList();
			
			for (int i = 0; i < list2.Count; i++)
			{

				if (list2.OrderBy(p => p.ID).ToList()[i].ID == (lstXe2.OrderBy(p => p.ID).ToList()[i]).ID)
				{
					continue;
				}
				result = false;
			}

			Assert.IsTrue(result);
		}
		//Tìm kiếm xe theo số ghế
		[Test]
		public void TC_U_03()
		{

			frm.cbb_soGhe.SelectedIndex = 2;
			frm.bt_search_Click(null, null);
			List<Xe> lstXe2 = list1;
			lstXe2 = lstXe2.Where(p => p.LoaiXe.SoGhe == 7).ToList();
			var list2 = frm.lstXeTest;
			bool result = true;
			for (int i = 0; i < list2.Count; i++)
			{

				if (list2.OrderBy(p => p.ID).ToList()[i].ID == (lstXe2.OrderBy(p => p.ID).ToList()[i]).ID)
				{
					continue;
				}
				result = false;
			}
			Assert.IsTrue(result);
		}

		//Test4 tìm kiếm thành công xe theo tên với xe không có trong db
		[Test]
        public void TC_U_04()
        {

            frm.tx_search.Text = "agno3";
			frm.bt_search_Click(null, null);
			var list2 = frm.lstXeTest;
           
            Assert.IsEmpty(list2);
        }
		//Test05 Thêm thành công xe vào danh sách xe chọn

		[Test]
		public void TC_U_05()
		{

			frm.ChoThueXeForm_Load(null, null);

			var data3 = "ca9af71a-22cd-462d-9407-0e8bca8078b9";
			DataGridViewCell cell;
			if (frm.dtgv_xeSS.RowCount > 2 && frm.dtgv_xeSS.ColumnCount > 1)
			{
                for (global::System.Int32 i = 0; i < frm.dtgv_xeSS.RowCount; i++)
                {
                    if (frm.dtgv_xeSS.Rows[i].Cells[7].Value.ToString()==data3)
                    {
						 cell = frm.dtgv_xeSS[2, i];
						frm.dtgv_xeSS.CurrentCell = cell;
						break;

					}
                }
           
			}
			frm.bt_add_Click(null, null);

			
			bool result = data3 == frm.maXe3;
			Assert.IsTrue(result);
		}
		//Xoá 1 xe khỏi danh sách xe đã chọn
		[Test]
		public void TC_U_06()
		{



			if (frm.dtgv_xeSS.RowCount > 2 && frm.dtgv_xeSS.ColumnCount > 1)
			{
				DataGridViewCell cell = frm.dtgv_xeSS[2, 1];
				frm.dtgv_xeSS.CurrentCell = cell;
			}
			frm.bt_add_Click(null, null);
			if (frm.dtgv_xeSS.RowCount > 2 && frm.dtgv_xeSS.ColumnCount > 1)
			{
				DataGridViewCell cell = frm.dtgv_xeSS[2, 2];
				frm.dtgv_xeSS.CurrentCell = cell;
			}
			frm.bt_add_Click(null, null);
			
				DataGridViewCell cell3 = frm.dtgv_xeChon[2, 1];
				frm.dtgv_xeChon.CurrentCell = cell3;
			frm.dt_delete_Click(null, null);


			var dataTest6 = frm.countXe6;
			Assert.AreEqual(dataTest6,1 );
		}
		//Test7 Xoá toàn bộ xe khỏi danh sách xe chọn
		[Test]
        public void TC_U_07()
        {



            if (frm.dtgv_xeSS.RowCount > 2 && frm.dtgv_xeSS.ColumnCount > 1)
            {
                DataGridViewCell cell = frm.dtgv_xeSS[2, 1];
                frm.dtgv_xeSS.CurrentCell = cell;
            }
            frm.bt_add_Click(null, null);
            if (frm.dtgv_xeSS.RowCount > 2 && frm.dtgv_xeSS.ColumnCount > 1)
            {
                DataGridViewCell cell = frm.dtgv_xeSS[2, 2];
                frm.dtgv_xeSS.CurrentCell = cell;
            }
            frm.bt_add_Click(null, null);
			var dataTest5 = frm.CountXeTest5;         
            Assert.AreEqual(0,dataTest5);
        }
     
		//Thêm hoá đơn thành công
		[Test]
		public void TC_U_08()
		{
			var data3 = "ca9af71a-22cd-462d-9407-0e8bca8078b9";
			DataGridViewCell cell;
			if (frm.dtgv_xeSS.RowCount > 2 && frm.dtgv_xeSS.ColumnCount > 1)
			{
				for (global::System.Int32 i = 0; i < frm.dtgv_xeSS.RowCount; i++)
				{
					if (frm.dtgv_xeSS.Rows[i].Cells[7].Value.ToString() == data3)
					{
						cell = frm.dtgv_xeSS[2, i];
						frm.dtgv_xeSS.CurrentCell = cell;
						break;

					}
				}

			}
			frm.bt_add_Click(null, null);
			frm.lb_idKhach.Text = "650b5e02-1e61-4aec-bb36-77118271226c";
			frm.tx_nameKhach.Text = "Nguyễn Khắc Phúc";
			frm.dkTest7 = true;
			frm.bt_pay_Click(null, null);

			Assert.IsTrue(frm.checkTest7);
		}
		//Test6 Tạo hoá đơn khi chưa chọn xe và khách hàng
		[Test]
		public void TC_U_09()
		{
			frm.bt_pay_Click(null, null);
			Assert.IsTrue(frm.checkTest6);
		}
		//Test10 Tạo hoá đơn thất bại khi chưa chọn khách hàng
		[Test]
		public void TC_U_10()
		{
			var data3 = "794c1f5d-9c1c-423f-b045-3096a5657de8";
			DataGridViewCell cell;
			if (frm.dtgv_xeSS.RowCount > 2 && frm.dtgv_xeSS.ColumnCount > 1)
			{
				for (global::System.Int32 i = 0; i < frm.dtgv_xeSS.RowCount; i++)
				{
					if (frm.dtgv_xeSS.Rows[i].Cells[7].Value.ToString() == data3)
					{
						cell = frm.dtgv_xeSS[2, i];
						frm.dtgv_xeSS.CurrentCell = cell;
						break;

					}
				}

			}
			frm.bt_add_Click(null, null);
			frm.bt_pay_Click(null, null);
			Assert.IsTrue(frm.checkTest10);
		}
	}
}