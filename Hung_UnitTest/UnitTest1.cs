
using System.Windows.Forms;
using CarRenTal.View._1.ChoThueXe;
using Dal.Modal;
using Dal.Repository;
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
		//lấy list xe từ db
		[Test]
		public void Test1()
		{
			frm.ChoThueXeForm_Load(null, null);
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

		//Test2 tìm kiếm danh sách xe theo tên 
		[Test]
		public void Test2()
		{
			
			frm.tx_search.Text = "CX-5";
			frm.ChoThueXeForm_Load(null, null);
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
		
		//Test2 tìm kiếm danh sách xe theo tên 
		[Test]
		public void Test3()
		{

			frm.ChoThueXeForm_Load(null, null);


			if (frm.dtgv_xeSS.RowCount > 2 && frm.dtgv_xeSS.ColumnCount > 1)
			{
				// Chọn ô cụ thể
				DataGridViewCell cell = frm.dtgv_xeSS[2, 1];
				frm.dtgv_xeSS.CurrentCell = cell;
			}		
			frm.bt_add_Click(null, null);

			var data3 = "ca9af71a-22cd-462d-9407-0e8bca8078b9";
			bool result = data3 == frm.maXe3;
			Assert.IsTrue(result);
		}
	}
}