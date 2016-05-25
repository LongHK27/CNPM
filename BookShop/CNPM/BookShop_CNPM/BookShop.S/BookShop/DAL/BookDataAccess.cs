using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop.Entities;

namespace BookShop.DAL
{
    public class BookDataAccess
    {
        /// <summary>
        /// Lấy thông tin sách đổ ra  dgv_Book
        /// </summary>
        /// <returns>dataGridView</returns>
        public static DataGridView getBookDAL()
        {
            DBConnection db = new DBConnection();
            DataGridView data = new DataGridView();
            var item = db.SACHes.Where(x => x.ISDELETE == true).ToList();
            data.DataSource = item;
            return data;
        }

        
    }
}
