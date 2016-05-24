using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShop.Entities;

namespace BookShop.BLL
{
    public class ChiTietHDBLL
    {
        /// <summary>
        /// Sửa số lượng trong hóa đơn
        /// </summary>
        /// <param name="mahd"></param>
        /// <param name="sach"></param>
        /// <param name="sl"></param>
        public static void edit(int mahd, int sach, int sl)
        {
            DBConnection db= new DBConnection();
            CHITIETHOADON cthd = db.CHITIETHOADONs.Find(mahd,sach);
            cthd.SOLUONG = sl;
            db.SaveChanges();
            
        }

        /// <summary>
        /// Lấy chi tiết hóa đơn theo mã hóa đơn
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<CHITIETHOADON> getCTHDByID(int id)
        {
            DBConnection db = new DBConnection();
            var item = db.CHITIETHOADONs.Where(n => n.ISDELETE != true && n.ID_HD == id).ToList();
            return item;
        }

        /// <summary>
        /// Xoa sach trong Hóa đơn
        /// </summary>
        /// <param name="maHD"></param>
        /// <param name="maSach"></param>
        public static void deleteCTHD(int maHD, int maSach)
        {
            DBConnection db = new DBConnection();
            var item = db.CHITIETHOADONs.Find(maHD, maSach);
            db.CHITIETHOADONs.Remove(item);
            db.SaveChanges();
        }
    }
}
