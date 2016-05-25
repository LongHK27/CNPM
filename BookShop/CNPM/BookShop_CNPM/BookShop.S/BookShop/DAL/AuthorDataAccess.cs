using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop.Entities;
using System.Data.Entity;

namespace BookShop.DAL
{

    public class AuthorDataAccess
    {
        /// <summary>
        /// Lấy thông tin tác giả đổ ra  dgv_Author
        /// </summary>
        /// <returns>dataGridView</returns>
        public static DataGridView getAuthorDAL()
        {
            DBConnection db= new DBConnection();
            DataGridView data = new DataGridView();
            var item = db.TACGIAs.Where(x => x.ISDELETE == true).ToList();
            data.DataSource = item;
            return data; 
        }
    }
}
