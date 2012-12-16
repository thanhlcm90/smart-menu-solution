﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS_Management.Database;
using SMS_Management.DataObject;

namespace SMS_Management
{
    class PayRepostitory : RepostitoryBase
    {
        public bool CheckPay(Guid order_id)
        {
            try
            {
                //Lấy dữ liệu order detail
                List<Guid > s = (from p in Context.ORDER_DETAIL
                            where p.ORDER_ID == order_id
                            select p.Id ).ToList();
                int c = (from p in Context.PROCESSING
                         where s.Contains(p.ORDERDTL_ID) && p.STATUS != "Đã bàn giao" select p).Count();
                return (c == 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SendToPayment(Guid order_id)
        {
            // Lấy dữ liệu order
            ORDER order = (from p in Context.ORDER
                           where p.STATUS=="Đang làm"
                           where p.Id == order_id
                           select p).SingleOrDefault();
            if (order == null) return false;
            
            //Lấy dữ liệu order detail
            List<ORDER_DETAIL> orderdtl;
            List<Guid> lstId;
            orderdtl = (from p in Context.ORDER_DETAIL
                        where p.ORDER_ID == order_id
                        select p).ToList();
            if (orderdtl.Count == 0) return false;
            lstId = (from p in orderdtl select p.Id).ToList();

            decimal money = 0;
            BILLING bill = new BILLING();
            bill.Id = Guid.NewGuid();
            bill.SELL_DATE = DateTime.Now;
            bill.TABLE_ID = order.TABLE_ID;
            bill.STATUS = "Chờ thanh toán";
            Context.BILLING.AddObject(bill);

            for (int i = 0; i < orderdtl.Count; i++)
            {
                BILLING_DETAIL billdtl = new BILLING_DETAIL();
                billdtl.Id = Guid.NewGuid();
                billdtl.DISH_ID = orderdtl[i].DISH_ID;
                billdtl.AMOUNT = orderdtl[i].AMOUNT;
                billdtl.CHEF_ID = orderdtl[i].CHEF_ID;
                billdtl.BILL_ID = bill.Id;
                money += (orderdtl[i].AMOUNT * orderdtl[i].DISH.PRICE);

                Context.BILLING_DETAIL.AddObject(billdtl);
                //Xóa bảng ORDER_DETAIL
                Context.ORDER_DETAIL.DeleteObject(orderdtl[i]);
            }
            bill.MONEY = money;
            //Xóa bảng ORDER
            Context.ORDER.DeleteObject(order);
            
            //Xóa bảng PROCCESSING
            List<PROCESSING> lstProccess = (from p in Context.PROCESSING
                                            where lstId.Contains(p.ORDERDTL_ID)
                                            select p).ToList();
            for (int i = 0; i < lstProccess.Count; i++)
            {
                Context.PROCESSING.DeleteObject(lstProccess[i]);
            }
                Context.SaveChanges();
            return true;
        }
        public List<BillingDTO> GetPayment()
        {
            try
            {
                List<BillingDTO> lst;
                lst = (from p in Context.BILLING.ToList()
                       orderby p.SELL_DATE descending 
                       where p.STATUS=="Chờ thanh toán"
                       select new BillingDTO()
                       {
                           ID = p.Id,
                           TABLE_ID = p.TABLE_ID,
                           CHEF_NAME = String.Join(", ",
                           (from n in p.BILLING_DETAIL
                            select n.CHEF_INFO.NAME).Distinct().ToArray()),
                           SELL_DATE = p.SELL_DATE,
                           REQUEST_COUNT = (from n in p.BILLING_DETAIL
                                            select n.AMOUNT).Sum(),
                           TABLE_NAME = p.TABLES_INFO.NAME,
                           WAITER_NAME = p.TABLES_INFO.WAITER_INFO.NAME,
                           STATUS = p.STATUS,
                           MONEY=p.MONEY
                       }).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool pay(Guid id)
        {
            BILLING bill = (from p in Context.BILLING where p.Id == id select p).SingleOrDefault();
            if (bill == null) return false;
            bill.STATUS = "Đã thanh toán";
            Context.SaveChanges();
            return true;
        }
    }
}