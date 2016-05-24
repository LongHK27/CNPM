using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShop.DAL;
using System.Windows.Forms;
using BookShop.Entities;

namespace BookShop.BLL
{
    public class HoaDonBLL
    {
    
         /// <summary>
         /// Lấy mã hóa đơn cho hóa đơn mới
         /// </summary>
         /// <returns></returns>
        public static int getMaHD()
        {
            
            try
            {
                DBConnection db = new DBConnection();
                var item = db.HOADONs.OrderByDescending(n=>n.ID).Take(1).SingleOrDefault();
                if (item==null)
                {
                    return 1;
                }
                return ++item.ID;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Không lấy được dữ liệu");
            }
            return 0;
        }
        /// <summary>
        /// Lấy tất cả hóa đơn trong CSDL
        /// </summary>
        /// <returns></returns>
        public static List<HOADON> getAllHD()
        {
            DBConnection db= new DBConnection();
            var item = db.HOADONs.Where(n => n.ISDELETE != true).ToList();
            return item;
        }

        public static int tongTienHD(List<CHITIETHOADON> listCTHD)
        {
            int tong=0;
            foreach (var item in listCTHD)
            {
                tong += (item.PTKM == 0) ? int.Parse((item.GIA * item.SOLUONG).ToString()) : int.Parse((item.GIA * item.SOLUONG * (1-item.PTKM/100)).ToString());
            }
            return tong;
        }
    }
}
