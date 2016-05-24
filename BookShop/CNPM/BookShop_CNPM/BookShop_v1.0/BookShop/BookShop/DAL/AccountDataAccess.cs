using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookShop.Entities;
using NHANVIEN = BookShop.Entities.NHANVIEN;

namespace BookShop.DAL
{
    class AccountDataAccess
    {
        /// <summary>
        /// Connection global
        /// </summary>
        private static readonly DBConnection DbGlb = new DBConnection();
 
        /// <summary>
        /// TODO: Check account is exsited in database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static NHANVIEN CheckAccount(string username, string password)
        {
            try
            {
                return
                (from a in DbGlb.NHANVIENs where a.TENDANGNHAP == username && a.MATKHAU == password select a)
                    .SingleOrDefault();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error!", MessageBoxButtons.OK);
                return null;
            }
            
        }

        /// <summary>
        /// TODO: get all account in data
        /// </summary>
        /// <returns></returns>
        public static DataGridView GetTable()
        {
            try
            {
                var data = new DataGridView {DataSource = (from a in DbGlb.NHANVIENs join b in DbGlb.PHANQUYENs on a.ID_QUYEN equals b.ID 
                 select new {a.ID, a.TENDANGNHAP, a.MATKHAU, a.TEN, a.NGAYSINH, a.ISDELETE, a.SDT, TENQUYEN = b.TEN, a.ID_QUYEN }).ToList() };
                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK);
                throw;
            }
        }

        public static List<NHANVIEN> GetAllAccount()
        {
            return (from a in DbGlb.NHANVIENs select a).ToList();
        }

        /// <summary>
        /// TODO: get one account
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static NHANVIEN GetItem(int id)
        {
            return (from a in DbGlb.NHANVIENs where a.ID == id select a).SingleOrDefault();
        }

        /// <summary>
        /// TODO: Insert new account to data
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool Insert(NHANVIEN item)
        {
            try
            {
                var lastOrDefault = (from a in DbGlb.NHANVIENs orderby a.ID descending select a).Take(1).SingleOrDefault();
                if (lastOrDefault != null)
                {
                    item.ID = lastOrDefault.ID + 1;
                }
                else
                {
                    item.ID = 1;
                }
                DbGlb.NHANVIENs.Add(item);
                DbGlb.SaveChanges();
                MessageBox.Show(@"Thêm thành công", "", MessageBoxButtons.OK);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "", MessageBoxButtons.OK);
                return false;
            }
        }

        /// <summary>
        /// TODO: Delete account
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(int id)
        {
            try
            {
                var item = (from a in DbGlb.NHANVIENs where a.ID == id select a).SingleOrDefault();

                if (item == null) return false;
                item.ISDELETE = true;

                DbGlb.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update(NHANVIEN account)
        {
            try
            {
                var item = (from a in DbGlb.NHANVIENs where a.ID == account.ID select a).SingleOrDefault();
                if (item == null) return false;

                item.TEN = account.TEN;
                item.TENDANGNHAP = account.TENDANGNHAP;
                item.SDT = account.SDT;
                item.MATKHAU = account.MATKHAU;
                item.ID_QUYEN = account.ID_QUYEN;
                item.NGAYSINH = account.NGAYSINH;

                DbGlb.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
       
    }
}
