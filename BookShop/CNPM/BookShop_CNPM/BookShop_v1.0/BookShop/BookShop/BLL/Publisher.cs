using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookShop.Entities;
using BookShop.DAL;

namespace BookShop.BLL
{
    class Publisher
    {
        public static NHAXUATBAN GetItem(int id)
        {
            var item = PublisherDataAccess.GetItem(id);
            if (item != null) return item;
            MessageBox.Show(@"Không có thông tin trong CSDL");
            return null;
        }

        public static DataGridView GetTable()
        {
            var table = PublisherDataAccess.GetTable();
            if (table != null) return table;
            MessageBox.Show(@"Không thể truy vấn dữ liệu!");
            return null;
        }

        public static List<NHAXUATBAN> GetTablePublisher()
        {
            var table = PublisherDataAccess.GetTablePublisher();
            if (table != null) return table;
            MessageBox.Show(@"Không thể truy vấn dữ liệu!");
            return null;
        }

        public static bool Insert(NHAXUATBAN newItem)
        {
            if (PublisherDataAccess.GetTablePublisher().Any(a=>a.TEN == newItem.TEN))
            {
                MessageBox.Show(@"Nhà Xuất Bản đã tồn tại!");
                return false;
            }

            if (string.IsNullOrEmpty(newItem.TEN))
            {
                MessageBox.Show(@"Tên nhà xuất bản không được để trống!");
                return false;
            }
            if (newItem.TEN.Length > 50)
            {
                MessageBox.Show(@"Tên nhà xuất bản phải ngắn hơn 50 ký tự!");
                return false;
            }
            if(newItem.SDT.Length > 13)
            {
                MessageBox.Show(@"Số điện thoại nhà xuất bản phải ngắn hơn 13 ký tự!");
                return false;
            }
            if (newItem.FAX.Length > 10)
            {
                MessageBox.Show(@"Số FAX nhà xuất bản phải ngắn hơn 10 ký tự!");
                return false;
            }

            if (PublisherDataAccess.Insert(newItem))
            {
                MessageBox.Show(@"Thêm thành công!");

            }
            return true;
        }

        public static bool Delete(int id)
        {
            if (PublisherDataAccess.Delete(id))
            {
                MessageBox.Show(@"Xóa thành công");
                return true;
            }
            MessageBox.Show(@"Xóa không thành công");
            return false;
        }

        public static bool Update(NHAXUATBAN publisher, int id)
        {
            if (PublisherDataAccess.Update(publisher, id))
            {
                MessageBox.Show(@"Thay đổi thành công");
                return true;
            }
            MessageBox.Show(@"Thay đổi không thành công");
            return false;
        }
    }
}
