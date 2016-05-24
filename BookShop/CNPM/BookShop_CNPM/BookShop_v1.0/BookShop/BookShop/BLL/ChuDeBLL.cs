using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShop.Entities;
using System.Windows.Forms;


namespace BookShop.BLL
{
    public class ChuDeBLL
    {
        public DBConnection db = null;
        public ChuDeBLL()
        {
             db = new DBConnection();
        }
        /// <summary>
        /// Sinh mã chủ đề mới
        /// </summary>
        /// <returns>int</returns>
        public static int getMa()
        {
            DBConnection db = new DBConnection();
            int id;
            CHUDE ma = db.CHUDEs.OrderByDescending(n=>n.ID).Take(1).SingleOrDefault();           
            if (ma == null)
            {
                id = 0;

            }
            else
            {
                id = ma.ID;
            }
            return ++id;
        }
       /// <summary>
       /// THêm mới một chủ đề
       /// </summary>
       /// <param name="id">Mã chủ đề mới</param>
       /// <param name="ten">Tên chủ đề mới</param>
       /// <returns></returns>
        public  bool add(string id, string ten)
        {
            try
            {
                CHUDE cd = new CHUDE();
                cd.ID = int.Parse(id);
                cd.TEN = ten;
                cd.ISDELETE = false;
                db.CHUDEs.Add(cd);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        /// <summary>
        /// Lấy tất cả chủ đề
        /// </summary>
        /// <returns>dataGridView</returns>
        public static DataGridView getChuDe()
        {
            DBConnection db = new DBConnection();
            var item= db.CHUDEs.ToList();
            DataGridView ret = new DataGridView();
            ret.DataSource = item;
            return ret;
        }
        /// <summary>
        /// Chỉnh sửa chủ đề
        /// </summary>
        /// <param name="id">ID của chủ đề cần chỉnh sửa</param>
        /// <param name="name">Tên mới của chủ đề</param>
        public static void edit(int id,string name,bool xoa)
        {
            CHUDE cd = new CHUDE();
            
            DBConnection db = new DBConnection();
            cd = db.CHUDEs.Find(id);
            cd.TEN = name;
            if (cd.ISDELETE!=xoa)
            {
                cd.ISDELETE = xoa;
            }
            db.SaveChanges();
            
        }
        /// <summary>
        /// Xóa chủ đề trong db
        /// </summary>
        /// <param name="id">Id của chủ đề</param>
        public static void delete(int id)
        {
            DBConnection db= new DBConnection();
            CHUDE cd = new CHUDE();
            cd = db.CHUDEs.Find(id);
            db.CHUDEs.Remove(cd);
            db.SaveChanges();
        }
    }
}
