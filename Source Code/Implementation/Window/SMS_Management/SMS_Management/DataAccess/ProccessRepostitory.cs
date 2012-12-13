using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS_Management.Database;
using SMS_Management.DataObject;

namespace SMS_Management
{
    class ProccessRepostitory : RepostitoryBase
    {
        public bool SendToChicken(Guid order_id)
        {
            try
            {
                // Lấy dữ liệu order
                ORDER order = (from p in Context.ORDER
                                  where p.Id == order_id
                                  select p).SingleOrDefault();
                if (order == null) return false;

                //Lấy dữ liệu order detail
                List<ORDER_DETAIL> orderdtl;
                orderdtl = (from p in Context.ORDER_DETAIL
                            where p.ORDER_ID == order_id && p.STATUS=="Chờ làm"
                            select p).ToList();
                if (orderdtl.Count == 0) return false;

                //Đếm số lượng món đang làm
                int c;
                c = (from p in Context.PROCESSING
                     where p.STATUS == "Đang làm"
                     select p.Id).Count();
                decimal m;
                m = (from p in Context.PROCESSING
                     select (decimal?)p.PRIORITY).Max() ?? 0;
                for (int i = 0; i < orderdtl.Count; i++)
                {
                    PROCESSING proccess = new PROCESSING();
                    proccess.Id = Guid.NewGuid();
                    proccess.AMOUNT = orderdtl[i].AMOUNT;
                    proccess.CHEF_ID = orderdtl[i].CHEF_ID;
                    proccess.DISH_ID = orderdtl[i].DISH_ID;
                    proccess.TALBLE_ID = order.TABLE_ID;
                    proccess.ORDERDTL_ID = orderdtl[i].Id;
                    if (i + c < 10)
                    {
                        proccess.PRIORITY = i + c + 1;
                        proccess.STATUS = "Đang làm";
                    }
                    else
                    {
                        proccess.PRIORITY = i+(int)m+1;
                        proccess.STATUS = "Chờ làm";
                    }
                    Context.PROCESSING.AddObject(proccess);
                    orderdtl[i].STATUS = "Đang làm";
                }
                
                //Thay đổi trạng thái của order
                order.STATUS = "Đang làm";

                //Commit change
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProccessingDTO> GetProccessingList()
        {
            try
            {
                List<ProccessingDTO> lst;
                lst = (from p in Context.PROCESSING
                       where p.STATUS=="Chờ làm" || p.STATUS=="Đang làm"
                       orderby p.PRIORITY 
                       select new ProccessingDTO()
                       {
                           ID = p.Id,
                           CHEF_NAME = p.CHEF_INFO.NAME,
                           DISH_NAME = p.DISH.NAME_VN,
                           TABLE_NAME = p.TABLES_INFO.NAME,
                           STATUS = p.STATUS,
                           AMOUNT = p.AMOUNT,
                           COMMENT=p.COMMENT,
                           PRIORITY=p.PRIORITY 
                       }).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProccessingDTO> GetProccessingListInChicken()
        {
            try
            {
                List<ProccessingDTO> lst;
                lst = (from p in Context.PROCESSING
                       where p.STATUS == "Đang làm"
                       select new ProccessingDTO()
                       {
                           ID = p.Id,
                           CHEF_NAME = p.CHEF_INFO.NAME,
                           DISH_NAME = p.DISH.NAME_VN,
                           TABLE_NAME = p.TABLES_INFO.NAME,
                           STATUS = p.STATUS,
                           AMOUNT = p.AMOUNT,
                           COMMENT = p.COMMENT
                       }).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProccessingDTO> GetProccessingFinishCancelList()
        {
            try
            {
                List<ProccessingDTO> lst;
                lst = (from p in Context.PROCESSING
                       where p.STATUS == "Hoàn thành" || p.STATUS == "Từ chối"
                       select new ProccessingDTO()
                       {
                           ID = p.Id,
                           CHEF_NAME = p.CHEF_INFO.NAME,
                           DISH_NAME = p.DISH.NAME_VN,
                           TABLE_NAME = p.TABLES_INFO.NAME,
                           STATUS = p.STATUS,
                           AMOUNT = p.AMOUNT,
                           COMMENT = p.COMMENT
                       }).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ConfirmCancelProcessing(Guid id)
        {
            PROCESSING processing = (from p in Context.PROCESSING where p.Id == id && p.STATUS=="Từ chối" select p).SingleOrDefault();
            if (processing == null) return false;
            ORDER_DETAIL dtl = (from p in Context.ORDER_DETAIL where p.Id == processing.ORDERDTL_ID select p).SingleOrDefault();
            if (dtl == null) return false;
            Context.PROCESSING.DeleteObject(processing);
            Context.ORDER_DETAIL.DeleteObject(dtl);
            Context.SaveChanges();
            return true;
        }

        public bool ConfirmFinishProcessing(Guid id)
        {
            PROCESSING processing = (from p in Context.PROCESSING where p.Id == id && p.STATUS=="Hoàn thành" select p).SingleOrDefault();
            if (processing == null) return false;
            processing.PRIORITY = 0;
            processing.STATUS = "Đã bàn giao";
            Context.SaveChanges();
            return true;
        }

        public bool FinishProcessing(int priority)
        {
            PROCESSING processing = (from p in Context.PROCESSING where p.PRIORITY == priority && p.STATUS == "Đang làm" select p).SingleOrDefault();
            if (processing == null) return false;
            List<PROCESSING> lst = (from p in Context.PROCESSING where p.PRIORITY > priority select p).ToList();
            for (int i = 0; i < lst.Count; i++)
            {
                lst[i].PRIORITY--;
                if (lst[i].PRIORITY <= 10) lst[i].STATUS = "Đang làm";
            }
            processing.STATUS = "Hoàn thành";
            Context.SaveChanges();
            return true;
        }

        public bool CancelProcessing(int priority)
        {
            PROCESSING processing = (from p in Context.PROCESSING where p.PRIORITY == priority && p.STATUS == "Đang làm" select p).SingleOrDefault();
            if (processing == null) return false;
            List<PROCESSING> lst = (from p in Context.PROCESSING where p.PRIORITY > priority select p).ToList();
            for (int i = 0; i < lst.Count; i++)
            {
                lst[i].PRIORITY--;
                if (lst[i].PRIORITY <= 10) lst[i].STATUS = "Đang làm";
            }
            processing.STATUS = "Từ chối";
            Context.SaveChanges();
            return true;
        }
    }
}
