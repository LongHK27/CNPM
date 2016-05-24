using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
