using Bus.Serviece.Interface;
using Bus.ViewModal;
using Dal.Data;
using Dal.Modal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus.Serviece.Implements
{
    public class HangXeServiece : IHangXeServiece
    {
        CarRentalDBContext _context;
        public HangXeServiece()
        {
            _context = new CarRentalDBContext();
        }

        public string CreatHangXe(HangXeVM p)
        {
            
            try
            {
                var existingHangXe = _context.hangXes.FirstOrDefault(h => h.Name == p.Name);

                if (existingHangXe != null)
                {
                    return "Tên đã tồn tại";
                }
                else
                {
                    var hangxe = new HangXe()
                    {
                        Id = Guid.NewGuid(), 
                        Name = p.Name,
                        TrangThai = p.TrangThai,
                    };

                    _context.Add(hangxe);
                    _context.SaveChanges();
                    return "Thành công";
                }


            }
            catch (Exception)
            {

                return "Không thành công";
            }
        }
      
        public bool DeleteHangXe(Guid id)
        {
            var del = _context.hangXes.FirstOrDefault(x => x.Id == id);
            if (del != null)
            {
                _context.hangXes.Remove(del);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<HangXe> GetAllHangXe()
        {
            var listHX =  _context.hangXes.ToList();

            return listHX ;
        }

        public bool GetHangXeById(Guid id)
        {
            try
            {
                var hangXe = _context.hangXes.FirstOrDefault(x => x.Id == id);

            // Trả về bản ghi HangXe nếu tìm thấy hoặc trả về null nếu không tìm thấy
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public bool GetHangXeByName(string name)
        {
            try
            {   
                _context.hangXes.FirstOrDefault(x=>x.Name == name);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public string GetTenHangXe(Guid id)
        {
            // Thực hiện truy vấn lấy thông tin tên hãng xe từ cơ sở dữ liệu dựa vào idHangXe
            HangXe hangXe = _context.hangXes.FirstOrDefault(h => h.Id == id);

            // Kiểm tra xem có tìm thấy hãng xe có Id là idHangXe không
            if (hangXe != null)
            {
                return hangXe.Name;
            }

            // Nếu không tìm thấy, trả về một giá trị mặc định hoặc chuỗi rỗng
            return string.Empty;
        }

        public string UpdateHangXe(HangXe p)
        {
            if (p == null) return "Unsuccessful";

            var hangXe = _context.hangXes.FirstOrDefault(c => c.Id == p.Id);
            if (hangXe == null) return "Unsuccessful";

            hangXe.Name = p.Name;
            hangXe.TrangThai = p.TrangThai;

            try
            {
                _context.Update(hangXe);
                _context.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine("Lỗi trong quá trình cập nhật dữ liệu: " + ex.Message);
                return "Unsuccessful";
            }
        }
    }
}
