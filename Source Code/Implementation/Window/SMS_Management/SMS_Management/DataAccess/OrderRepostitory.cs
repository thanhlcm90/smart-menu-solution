using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS_Management.Database;
using SMS_Management.DataObject;

namespace SMS_Management
{
    class OrderRepostitory : RepostitoryBase
    {
        public OrderDetailDTO GetOrderDetailFromCode(string RcvCode)
        {
            //Received Code AXXYYYZZ
            if (RcvCode.Length == 8)
            {
                // Get command code A
                short A = Convert.ToInt16(RcvCode.Substring(0, 1));

                // Get table code XX
                short XX = Convert.ToInt16(RcvCode.Substring(1, 2));

                // Get dish code YYY
                short YYY = Convert.ToInt16(RcvCode.Substring(3, 3));

                // Get quantity ZZ
                short ZZ = Convert.ToInt16(RcvCode.Substring(6, 2));

                OrderDetailDTO query;
                query = (from p in Context.TABLES_INFO
                         from n in Context.DISH
                         where p.CODE == XX && n.CODE == YYY
                         select new OrderDetailDTO()
                         {
                             AMOUNT = ZZ,
                             DISH_NAME = n.NAME_VN,
                             DISH_ID=n.Id,
                             TABLE_CODE=XX,
                             AREA=n.AREA,
                             DISH_TYPE_NAME=n.DISH_TYPE.NAME,
                             MATERIA=n.MATERIAL,
                             PRICE=n.PRICE,
                             MONEY=ZZ*n.PRICE,
                             STATUS = "Chờ làm"
                         }).FirstOrDefault ();
                return query;
            }
            return null;
        }

        public string GetTableName(short table_code)
        {
            string strName = (from p in Context.TABLES_INFO
                              where p.CODE == table_code
                              select p.NAME).SingleOrDefault();
            return strName;
        }

        public List<OrderDTO> GetOrderList()
        {
            try
            {
                List<OrderDTO> lst;
                lst = (from p in Context.ORDER.ToList()
                       orderby p.ADD_TIME descending 
                        select new OrderDTO()
                        {
                            ID=p.Id,
                            TABLE_ID=p.TABLE_ID,
                            CHEF_NAME = String.Join(", ",
                            (from n in p.ORDER_DETAIL 
                            select n.CHEF_INFO.NAME).Distinct().ToArray()),
                            ADD_TIME=p.ADD_TIME,
                            REQUEST_COUNT=(from n in p.ORDER_DETAIL
                                            select n.AMOUNT).Sum(),
                            PROCCESSING_COUNT = (from n in p.ORDER_DETAIL
                                                 where n.STATUS == "Đang làm"
                                                 select n.AMOUNT).Sum(),
                            TABLE_NAME=p.TABLES_INFO.NAME,
                            WAITER_NAME=p.TABLES_INFO.WAITER_INFO.NAME,
                            STATUS=p.STATUS
                        }).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Inserted ordered dishes
        public Boolean InsertOrdered(List<OrderDetailDTO> lst, short table_code)
        {
            try
            {

                ORDER order;
                OrderDTO query = (from p in Context.ORDER
                                  where p.TABLES_INFO.CODE == table_code
                                  select new OrderDTO()
                                  {
                                     ID=p.Id,
                                     STATUS=p.STATUS 
                                  }).SingleOrDefault();
                if (query == null)
                {
                    order = new ORDER();
                    query = new OrderDTO();
                    order.Id = Guid.NewGuid();
                    query.ID = order.Id;
                    Guid table_id = (from p in Context.TABLES_INFO where p.CODE == table_code select p.Id).SingleOrDefault();
                    order.TABLE_ID = table_id;
                    order.ADD_TIME = DateTime.Now;
                    order.STATUS = "Chờ xác nhận";
                    query.STATUS = order.STATUS;
                    Context.ORDER.AddObject(order);
                }
                foreach (OrderDetailDTO item in lst)
                {
                    ORDER_DETAIL orderdtl = new ORDER_DETAIL();
                    orderdtl.Id  = Guid.NewGuid();
                    ChefDTO chef = GetChefFree();
                    if (chef != null) orderdtl.CHEF_ID = chef.ID;
                    orderdtl.AMOUNT = item.AMOUNT;
                    orderdtl.DISH_ID = item.DISH_ID;
                    orderdtl.ORDER_ID = query.ID;
                    orderdtl.STATUS = "Chờ làm";
                    Context.ORDER_DETAIL.AddObject(orderdtl);
                }
                Context.SaveChanges();
                if (query.STATUS == "Đang làm")
                {
                    ProccessRepostitory rep = new ProccessRepostitory();
                    rep.SendToChicken(query.ID);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Cancel ordered dishes
        public Boolean CancelOrdered(OrderDetailDTO lst)
        {
            try
            {
                ORDER_DETAIL query = (from p in Context.ORDER_DETAIL
                                  where p.ORDER.TABLES_INFO.CODE == lst.TABLE_CODE &&
                                  p.DISH_ID==lst.DISH_ID &&
                                  p.STATUS!="Chờ làm"
                                  select p).FirstOrDefault();
                PROCESSING query1 = (from p in Context.PROCESSING 
                                     where p.ORDERDTL_ID == query.Id 
                                     select p).FirstOrDefault();

                if (query == null) return false;
                if (query.AMOUNT <= lst.AMOUNT)
                {
                    Context.ORDER_DETAIL.DeleteObject(query);
                    Context.PROCESSING.DeleteObject(query1);
                }
                else if (query.AMOUNT > lst.AMOUNT)
                {
                    query.AMOUNT -= lst.AMOUNT;
                    query1.AMOUNT -= query1.AMOUNT;
                }
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private ChefDTO GetChefFree() 
        {
            List<ChefDTO> lst=(from p in Context.CHEF_INFO 
                                select new ChefDTO() {
                                    ID=p.Id,
                                    ADDRESS=p.ADDRESS,
                                    BIRTHDAY=p.BIRTHDAY,
                                    NAME=p.NAME,
                                    PHONE=p.PHONE}).ToList();
            int max=int.MaxValue;
            ChefDTO result=null;
            for (int i=0;i<lst.Count;i++) 
            {
                Guid id=lst[i].ID;
                decimal c = ((from p in Context.PROCESSING 
                            where p.CHEF_ID==id && p.AMOUNT != null
                            select (decimal?)p.AMOUNT).Sum()) ?? 0;
                if (c<max) {
                    max=(int)c;
                    result=lst[i];
                }
            }
            return result;
        }
    }
}
