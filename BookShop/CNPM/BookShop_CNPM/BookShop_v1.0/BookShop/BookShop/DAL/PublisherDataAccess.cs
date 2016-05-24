using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookShop.Entities;

namespace BookShop.DAL
{
    class PublisherDataAccess
    {
        public static readonly DBConnection Db = new DBConnection();

        public static NHAXUATBAN GetItem(int id)
        {
            try
            {
                return (from a in Db.NHAXUATBANs where a.ID == id select a).SingleOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<NHAXUATBAN> GetTablePublisher()
        {
            try
            {
                return (from a in Db.NHAXUATBANs select a).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static DataGridView GetTable()
        {
            try
            {
                return new DataGridView { DataSource = (from a in Db.NHAXUATBANs orderby a.ISDELETE descending select a).ToList()};
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Insert(NHAXUATBAN item)
        {
            try
            {
                var last = (from a in Db.NHAXUATBANs orderby a.ID descending select a).Take(1).SingleOrDefault();
                if (last == null)
                {
                    item.ID = 1;
                }
                else
                {
                    item.ID = last.ID + 1;
                }
                item.ISDELETE = false;
                Db.NHAXUATBANs.Add(item);
                Db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update(NHAXUATBAN publisherChange, int id)
        {
            try
            {
                var item = (from a in Db.NHAXUATBANs where a.ID == id select a).SingleOrDefault();
                if (item == null) return false;

                item.TEN = publisherChange.TEN;
                item.DIACHI = publisherChange.DIACHI;
                item.SDT = publisherChange.SDT;
                item.FAX = publisherChange.FAX;
                item.GIOITHIEU = publisherChange.GIOITHIEU;
                item.ISDELETE = publisherChange.ISDELETE;

                Db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete(int id)
        {
            try
            {
                var item = (from a in Db.NHAXUATBANs where a.ID == id select a).SingleOrDefault();
                if (item == null) return false;
                item.ISDELETE = true;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
