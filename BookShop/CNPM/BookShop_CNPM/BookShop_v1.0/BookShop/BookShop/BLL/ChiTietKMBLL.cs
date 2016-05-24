using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShop.Entities;
using BookShop.DAL;
using System.Windows.Forms;

namespace BookShop.BLL
{
    public class ChiTietKMBLL
    {
        DBConnection db;
        public ChiTietKMBLL()
        {
            db = new DBConnection();
        }

        public void add(List<CHITIETKM> ctkm)
        {
            db.CHITIETKMs.AddRange(ctkm);
            db.SaveChanges();
        }
        /// <summary>
        /// Lấy chi tiết khuyến mại theo mã khuyến mại
        /// </summary>
        /// <param name="id">Mã khuyến mại</param>
        /// <returns></returns>
        public static DataGridView getCTKM(int id)
        {
            DBConnection db = new DBConnection();
            DataGridView data = new DataGridView();
            var item = db.CHITIETKMs.Where(n => n.ID_KM == id).ToList();
            data.DataSource = item;
            return data;
        }
        /// <summary>
        /// Sửa lại phần trăm khuyến mại cho sách
        /// </summary>
        /// <param name="makm">Mã khuyến mại</param>
        /// <param name="maSach">Mã sách</param>
        /// <param name="pTKM"></param>
        public void editCTKM(int makm, int maSach, int pTKM) 
        {
            CHITIETKM ctkm = db.CHITIETKMs.Find(makm, maSach);
            ctkm.PTKM = pTKM;
            db.SaveChanges();
        }
        /// <summary>
        /// Xóa sách khuyến mại trong chi tiết khuyến mại
        /// </summary>
        /// <param name="makm"></param>
        /// <param name="maSach"></param>
        public void deleteCTKM(int makm, int maSach)
        {
            CHITIETKM ctkm = db.CHITIETKMs.Find(makm, maSach);
            db.CHITIETKMs.Remove(ctkm);
            db.SaveChanges();
        }
        /// <summary>
        /// Lấy ptkm còn khả dụng
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int getPTKMIDSach(int id)
        {
            int max=0;
            DBConnection db = new DBConnection();
            var item = db.CHITIETKMs.Join(db.KHUYENMAIs, km => km.ID_KM, ctkm => ctkm.ID, (ctkm, km) => new { ctkm, km }).
                Where(n => n.km.NGAYBATDAU <= DateTime.Now && n.km.NGAYKETTHUC >= DateTime.Now && n.km.ISDELETE!=true).ToList();
            if (item==null)
            {
                return 0;
            }
            else
            {
                
                foreach (var a in item)
                {

                    if (max<int.Parse(a.ctkm.PTKM.ToString()))
                    {
                        max = int.Parse(a.ctkm.PTKM.ToString());
                    }
                }
            }
            return max;
        }
    }
}
