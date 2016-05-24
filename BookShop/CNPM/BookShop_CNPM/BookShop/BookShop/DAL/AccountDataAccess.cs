using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop.Entities;

namespace BookShop.DAL
{
    class AccountDataAccess
    {
        /// <summary>
        /// Connection global
        /// </summary>
        private static readonly DBConnection Db_glb = new DBConnection();

        public static NHANVIEN CheckAccount(string username, string password)
        {
            try
            {
                return
                (from a in Db_glb.NHANVIENs where a.TENDANGNHAP == username && a.MATKHAU == password select a)
                    .SingleOrDefault();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK);
                return null;
            }
            
        }
    }
}
