using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop.DAL;
using BookShop.Entities;
using System.Data.Entity;


namespace BookShop.BLL
{
    public class AuthorBLL
    {
        /// <summary>
        /// Connection global
        /// </summary>
        DBConnection db;
        public AuthorBLL()
        {
            db = new DBConnection();
        }
        /// <summary>
        /// Đưa dữ liệu lên form
        /// </summary>
        /// <returns>Datagridview</returns>
        public static DataGridView getAllAuthor()
        {
            return AuthorDataAccess.getAuthorDAL();
        }
        /// <summary>
        /// lấy ID sách mới
        /// </summary>
        /// <returns>int</returns>
        public static int loadID()
        {
            var db = new DBConnection();
            var item = db.TACGIAs.OrderByDescending(n => n.ID).Take(1).SingleOrDefault();
            if (item == null)
            {
                return 1;
            }
            return ++item.ID;
        }
        /// <summary>
        /// THêm mới một tác giả
        /// </summary>
        /// <param name="id">Mã tác giả</param>
        /// <param name="name">Tên tác giả</param>
        /// <param name="phone">Số điện thoại</param>
        /// <param name="dc">ĐỊa chỉ</param>
        /// <param name="data">DaGridView</param>
        public static void createAuthor(int id, string name, string phone, string dc)
        {
            DBConnection db = new DBConnection();
            TACGIA tg = new TACGIA();
            tg.ID = id;
            tg.TEN = name.Trim();
            tg.DIACHI = dc.Trim();
            tg.SDT = phone;
            tg.ISDELETE = true;
            db.TACGIAs.Add(tg);
            db.SaveChanges();
        }
        /// <summary>
        /// Cập nhật 1 tác giả mới
        /// </summary>
        /// <param name="id">Mã tác giả</param>
        /// <param name="name">Tên tác giả</param>
        /// <param name="phone">Số điện thoại</param>
        /// <param name="dc">Địa chỉ</param>
        public static void updateAuthor(int id,string name, string phone, string dc)
        {
            DBConnection db = new DBConnection();
            TACGIA tg = new TACGIA();
            tg.ID = id;
            tg.TEN = name.Trim();
            tg.SDT = phone;
            tg.DIACHI = dc.Trim();
            db.TACGIAs.Attach(tg);
            tg.ISDELETE = true;
            var entry = db.Entry(tg);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
        /// <summary>
        /// Xóa 1 tác giả
        /// </summary>
        /// <param name="id">Mã tác giả</param>
        public static void deleteAuthor(int id)
        {
            DBConnection db = new DBConnection();
            TACGIA tg = new TACGIA();
            tg.ID = id;
            db.TACGIAs.Attach(tg);
            db.TACGIAs.Remove(tg);
            db.SaveChanges();
            
        }
        /// <summary>
        /// Tìm kiếm 1 tác giả
        /// </summary>
        /// <param name="name"></param>
        /// <returns>datagridview</returns>
        public static DataGridView searchAuthor(string name)
        {
            DBConnection db = new DBConnection();
            DataGridView data = new DataGridView();
            var item = db.TACGIAs.Where(x => x.ISDELETE == true).ToList().FindAll(x => x.TEN == name);
            data.DataSource = item;
            return data;
        }
    }
}
