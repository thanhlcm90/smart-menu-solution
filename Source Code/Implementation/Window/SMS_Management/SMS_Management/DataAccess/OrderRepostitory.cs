using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS_Management.Database;
using SMS_Management.DataObject;

namespace SMS_Management
{
    class OrderRepostitory
    {

        SMS_DatabaseEntities _ctx;
        public SMS_DatabaseEntities Context
        {
            get
            {
                if (_ctx == null)
                {
                    _ctx = new SMS_DatabaseEntities();
                    _ctx.ContextOptions.LazyLoadingEnabled = true;
                }
                return _ctx;
            }
        }

        public OrderDTO GetFromCode(string RcvCode)
        {
            //Received Code AXXYYYZZ
            //if (RcvCode.Length == 8)
            //{
            //    // Get command code A
            //    int A = Convert.ToInt32(RcvCode.Substring(0, 1));

            //    // Get table code XX
            //    int XX = Convert.ToInt32(RcvCode.Substring(1, 2));

            //    // Get dish code YYY
            //    int YYY = Convert.ToInt32(RcvCode.Substring(3, 3));

            //    // Get quantity ZZ
            //    int ZZ = Convert.ToInt32(RcvCode.Substring(6, 2));

            //    OrderDTO query;
            //    query = (from p in Context.TABLES_INFO
            //             from n in Context.DISH
            //             where p.CODE == XX && n.CODE == YYY
            //             select new OrderDTO()
            //             {
            //                 TABLE_NAME = p.NAME,
            //                 DISH_NAME = n.NAME_VN,
            //                 DISH_AMOUNT = ZZ,
            //                 WAITER_NAME = p.WAITER_INFO.NAME,
            //                 STATUS = "Đang làm"
            //             }).SingleOrDefault();
            //    return query;
            //}
            //return null;
        }


        //List ordered dishes
        public List<ORDER> GetOrdered()
        {
            try
            {
                List<ORDER> lst = (from p in Context.ORDER  select p).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ORDER  GetOrderedByID(Guid id)
        {
            try
            {
                ORDER lst = (from p in Context.ORDER where p.Id == id select p).SingleOrDefault();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TABLES_INFO GetTableIDhaveName(string tbName)
        {
            try
            {
                TABLES_INFO lst = (from p in Context.TABLES_INFO where p.NAME == tbName select p).SingleOrDefault();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ORDER> GetOrderedByTableID(Guid id)
        {
            try
            {
                List<ORDER> lst = (from p in Context.ORDER where p.TABLE_ID == id select p).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Inserted ordered dishes
        public Boolean InsertOrdered(ORDER lst)
        {
            try
            {
                lst.Id = Guid.NewGuid();
                Context.ORDER.AddObject(lst);
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
