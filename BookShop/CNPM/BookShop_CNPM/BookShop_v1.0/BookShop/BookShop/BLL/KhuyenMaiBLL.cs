using System.Linq;
using BookShop.DAL;
using BookShop.Entities;
using System.Windows.Forms;

namespace BookShop.BLL
{
    public class KhuyenMaiBLL
    {
        readonly DBConnection _db;
        public KhuyenMaiBLL()
        {
            _db = new DBConnection();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DataGridView getAllSach()
        {
            var db = new DBConnection();
            var data = new DataGridView();
            var lst = db.SACHes.Select(n => new SachDAL
            {
                ID = n.ID,
                TEN = n.TEN,
                ID_NXB = n.ID_NXB,
            }).ToList();
            data.DataSource = lst;
            return data;
        }
        /// <summary>
        /// Lấy tên sách đổ vào comboBox
        /// </summary>
        /// <returns></returns>
        public static ComboBox getAllTenSach()
        {
            var db= new DBConnection();
            var cbx = new ComboBox();
            var item = db.SACHes.Select(n => new {n.ID,n.TEN }).ToList();
            cbx.DataSource = item;
            return cbx;
        }
        /// <summary>
        /// Lấy mã khuyến mại cho khuyến mại mới
        /// 
        /// </summary>
        /// <returns></returns>
        public static int getMaKM() 
        {
            var db= new DBConnection();

            var item = db.KHUYENMAIs.OrderByDescending(n => n.ID).Take(1).SingleOrDefault();
            var ret = item==null ? 1 : int.Parse(item.ID.ToString());
            
            ret++;
            return ret;
        }


        /// <summary>
        /// Load toàn bộ khuyến mại đổ lên dataGridView
        /// </summary>
        /// <returns></returns>
        public static DataGridView getAllKM() 
        {
            var db = new DBConnection();
            var data = new DataGridView();
            var item = db.KHUYENMAIs.Where(n=>n.ISDELETE!=true).ToList();
            data.DataSource = item;
            return data;
        }


        /// <summary>
        /// Thêm khuyến mại vào CSDL
        /// </summary>
        /// <param name="maKm">Mã km</param>
        /// <param name="tenKm">Tên khuyến mại</param>
        /// <param name="ngBd">Ngày bắt đầu khuyến mại</param>
        /// <param name="ngKt">Ngày kết thúc khuyến mại</param>
        public void add(KHUYENMAI km)
        {
            _db.KHUYENMAIs.Add(km);
            _db.SaveChanges();
        }


        /// <summary>
        /// Xóa một khuyến mại
        /// </summary>
        /// <param name="makm"></param>
        public void deleteKM(int makm)
        {
            var item = _db.CHITIETKMs.Where(n => n.ID_KM == makm).ToList();
            foreach (CHITIETKM a in item){
                a.ISDELETE= true;
                _db.SaveChanges();
            }
            var km = _db.KHUYENMAIs.Find(makm);
            if (km == null) return;
            km.ISDELETE = true;
            _db.SaveChanges();
        }
        
    }
}
