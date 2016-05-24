using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BookShop.Entities;
using BookShop.DAL;

namespace BookShop.BLL
{
    class Account
    {
        public static NHANVIEN Login(string username, string password)
        {
            return AccountDataAccess.CheckAccount(username, password);
        }

        public static DataGridView GetTable()
        {
            return AccountDataAccess.GetTable();
        }

        public static NHANVIEN GetItem(int id)
        {
            return AccountDataAccess.GetItem(id);
        }

        public static void Insert(NHANVIEN item, string repassword)
        {
            
            if (AccountDataAccess.GetAllAccount().Any(a => a.TENDANGNHAP == item.TENDANGNHAP))
            {
                MessageBox.Show(@"Tài khoản đã tồn tại!");
                return;
            }
            if (repassword != item.MATKHAU)
            {
                MessageBox.Show(@"Mật khẩu không trùng!");
                return;
            }
            if (item.TENDANGNHAP.Length >= 20)
            {
                MessageBox.Show(@"Độ dài Tên đăng nhập không dài quá 20 ký tự!");
                return;
            }
            if (item.TEN.Length >= 50)
            {
                MessageBox.Show(@"Độ dài Tên tài khoản không dài quá 50 ký tự!");
                return;
            }
            if (item.MATKHAU.Length >= 50)
            {
                MessageBox.Show(@"Độ dài Mật khẩu không dài quá 50 ký tự!");
                return;
            }
            if (item.SDT.Length >= 13)
            {
                MessageBox.Show(@"Độ dài Số điện thoại không dài quá 20 ký tự!");
                return;
            }
            if (Regex.Matches(item.SDT,@"[0-9]").Count != item.SDT.Length)
            {
                MessageBox.Show(@"Số điện thoại không được chứa ký tự!");
                return;
            }
            if (string.IsNullOrEmpty(item.TENDANGNHAP) || string.IsNullOrEmpty(item.MATKHAU))
            {
                MessageBox.Show(@"Tên đăng nhập và mật khẩu không được trống!");
                return;
            }
            AccountDataAccess.Insert(item);
        }

        public static void Delete(int id)
        {
            MessageBox.Show(AccountDataAccess.Delete(id) ? @"Xóa thành công!" : @"Không thể xóa!");
        }

        /// <summary>
        /// TODO: Update infor account
        /// </summary>
        /// <param name="account"></param>
        /// <param name="repassword"></param>
        /// <returns></returns>
        public static bool Update(NHANVIEN account, string repassword)
        {
            var item = AccountDataAccess.GetItem(account.ID);
            if (item.ISDELETE == true)
            {
                MessageBox.Show(@"tài khoản đã xóa, không thể thay đổi dữ liệu");
                return false;
            }
            if (repassword != account.MATKHAU && item.MATKHAU != account.MATKHAU)
            {
                MessageBox.Show(@"Mật khẩu không trùng!");
                return false;
            }
            if (account.TENDANGNHAP.Length >= 20)
            {
                MessageBox.Show(@"Độ dài Tên đăng nhập không dài quá 20 ký tự!");
                return false;
            }
            if (account.TEN.Length >= 50)
            {
                MessageBox.Show(@"Độ dài Tên tài khoản không dài quá 50 ký tự!");
                return false;
            }
            if (account.MATKHAU.Length >= 10)
            {
                MessageBox.Show(@"Độ dài Mật khẩu không dài quá 10 ký tự!");
                return false;
            }
            if (account.SDT.Length >= 13)
            {
                MessageBox.Show(@"Độ dài Số điện thoại không dài quá 20 ký tự!");
                return false;
            }
            if (Regex.Matches(account.SDT, @"[0-9]").Count != account.SDT.Length)
            {
                MessageBox.Show(@"Số điện thoại không được chứa ký tự!");
                return false;
            }
            if (string.IsNullOrEmpty(account.TENDANGNHAP) || string.IsNullOrEmpty(account.MATKHAU))
            {
                MessageBox.Show(@"Tên đăng nhập và mật khẩu không được trống!");
                return false;
            }

            if (!AccountDataAccess.Update(account)) return false;
            MessageBox.Show(@"Thay đổi dữ liệu thanh công!");
            return true;
        }
    }
}
