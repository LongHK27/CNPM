using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop.DAL;
using BookShop.Entities;

namespace BookShop.BLL
{
    public class BillBLL
    {
        /// <summary>
        /// Connection global
        /// </summary>
        DBConnection db;
        public BillBLL()
        {
            db = new DBConnection();
        }
        /// <summary>
        /// Đưa danh sách những phiếu nhập lên view
        /// </summary>
        /// <returns>datagridview</returns>
        public static DataGridView getAllBill()
        {
            return BillDataAccess.getBillDAL();
        }
        /// <summary>
        /// lấy ID phiếu nhập mới
        /// </summary>
        /// <returns>int</returns>
        public static int loadID()
        {
            var db = new DBConnection();
            var item = db.PHIEUNHAPs.OrderByDescending(n => n.ID).Take(1).SingleOrDefault();
            if (item == null)
            {
                return 1;
            }
            return ++item.ID;
        }
        /// <summary>
        /// lấy đữ liệu nhà xuất bản đổ vào combobox
        /// </summary>
        /// <returns>list</returns>
        public static List<NHAXUATBAN> getNxbCBX()
        {
            var db = new DBConnection();
            var lstcd = db.NHAXUATBANs.Where(n => n.ISDELETE != true).ToList();
            return lstcd;
        }
        /// <summary>
        /// Thêm mới phiếu nhập
        /// </summary>
        /// <param name="id">mã phiếu</param>
        /// <param name="id_nxb">mã nhà xuất bản</param>
        /// <param name="ngay">ngày nhập</param>
        /// <param name="sl"> số lượng</param>
        public static void createBill(int id, int id_nxb, DateTime ngay, int sl)
        {
            DBConnection db = new DBConnection();
            PHIEUNHAP pn = new PHIEUNHAP();
            pn.ID = id;
            pn.ID_NXB = id_nxb;
            pn.NGAYNHAP = ngay;
            pn.SOLUONG = sl;
            pn.ISDELETE = true;
            db.PHIEUNHAPs.Attach(pn);
            db.PHIEUNHAPs.Add(pn);
            db.SaveChanges();
        }
        /// <summary>
        /// Sửa thông tin phiếu nhập
        /// </summary>
        /// <param name="id">mã phiếu</param>
        /// <param name="id_nxb">mã nhà xuất bản</param>
        /// <param name="ngay">ngày nhập</param>
        /// <param name="sl"> số lượng</param>
        public static void updateBill(int id, int id_nxb, DateTime ngay, int sl)
        {
            DBConnection db = new DBConnection();
            PHIEUNHAP pn = new PHIEUNHAP();
            pn.ID = id;
            pn.ID_NXB = id_nxb;
            pn.NGAYNHAP = ngay;
            pn.SOLUONG = sl;
            pn.ISDELETE = true;
            db.PHIEUNHAPs.Attach(pn);
            var entry = db.Entry(pn);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
        /// <summary>
        /// Xóa 1 phiếu nhập
        /// </summary>
        /// <param name="id">mã phiếu</param>
        public static void deleteBill(int id)
        {
            DBConnection db = new DBConnection();
            PHIEUNHAP pn = new PHIEUNHAP();
            pn.ID = id;
            db.PHIEUNHAPs.Attach(pn);
            db.PHIEUNHAPs.Remove(pn);
            db.SaveChanges();
        }
        /// <summary>
        /// Tìm kiếm 1 phiếu nhập
        /// </summary>
        /// <param name="name"></param>
        /// <returns>datagridview</returns>
        public static DataGridView searchBill(int id)
        {
            DBConnection db = new DBConnection();
            DataGridView data = new DataGridView();
            var item = db.PHIEUNHAPs.Where(x => x.ISDELETE == true).ToList().FindAll(x => x.ID == id);
            data.DataSource = item;
            return data;
        }
    }
}
