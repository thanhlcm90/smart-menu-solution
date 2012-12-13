using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS_Management.Database;
using SMS_Management.DataObject;

namespace SMS_Management
{
    class PayRepostitory : RepostitoryBase
    {
        public bool pay(Guid order_id)
        {
            // Lấy dữ liệu order
            ORDER order = (from p in Context.ORDER
                           where p.Id == order_id
                           select p).SingleOrDefault();
            if (order == null) return false;

            //Lấy dữ liệu order detail
            List<ORDER_DETAIL> orderdtl;
            orderdtl = (from p in Context.ORDER_DETAIL
                        where p.ORDER_ID == order_id && p.STATUS == "Chờ làm"
                        select p).ToList();
            if (orderdtl.Count == 0) return false;

            decimal money = 0;
            BILLING bill = new BILLING();
            bill.Id = Guid.NewGuid();
            bill.SELL_DATE = DateTime.Now;
            bill.TABLE_ID = order.TABLE_ID;

            for (int i = 0; i < orderdtl.Count; i++)
            {
                BILLING_DETAIL billdtl = new BILLING_DETAIL();
                billdtl.Id = Guid.NewGuid();
                billdtl.DISH_ID = orderdtl[i].DISH_ID;
                billdtl.AMOUNT = orderdtl[i].AMOUNT;
                billdtl.CHEF_ID = orderdtl[i].CHEF_ID;
                billdtl.BILL_ID = bill.Id;
                money += (billdtl.AMOUNT * billdtl.DISH.PRICE);

                Context.BILLING_DETAIL.AddObject(billdtl);
            }
            bill.MONEY = money;
            Context.BILLING.AddObject(bill);
            Context.SaveChanges();
            return true;
        }
        //public List<OrderDTO> GetPayment()
        //{
        //    try
        //    {
        //        List<BillingDTO> lst;
                
        //        return lst;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

    }
}
