using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop.Entities;

namespace BookShop.DAL
{
    public class BillDataAccess
    {
        /// <summary>
        /// Lấy thông tin phiếu nhập đổ ra  dgv_Bill
        /// </summary>
        /// <returns>dataGridView</returns>
        public static DataGridView getBillDAL()
        {
            DBConnection db = new DBConnection();
            DataGridView data = new DataGridView();
            var item = db.PHIEUNHAPs.Where(x => x.ISDELETE == true).ToList();
            data.DataSource = item;
            return data;
        }
    }
}
