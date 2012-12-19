using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS_Management.Database;
using SMS_Management.DataObject;

namespace SMS_Management
{
    class WaiterRepostitory : RepostitoryBase
    {  public WAITER_INFO GetWaterName(Guid ID)
        {
            try
            {

                WAITER_INFO alo = (from p in Context.WAITER_INFO
                                  where p.Id == ID
                          select p).SingleOrDefault();


               
                return alo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> GetWaiterNameList()
        {
            try
            {

                var alo = from p in Context.WAITER_INFO

                          select p.NAME;


                List<string> y = alo.ToList();
                return y;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Lấy list danh sách phục vụ

        public List<WaiterDTO> GetWaiterList()
        {
            try
            {
                List<WaiterDTO> lst;
                lst = (from p in Context.WAITER_INFO
                       select new WaiterDTO()
                       {
                           ID = p.Id,
                           NAME = p.NAME,
                           ADDRESS = p.ADDRESS,
                           BIRTHDAY = p.BIRTHDAY,
                           PHONE = p.PHONE
                       }).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Cập nhật 1 phục vụ
        public Boolean UpdateWaiter(WaiterDTO lst)
        {
            try
            {
                WAITER_INFO query = (from p in Context.WAITER_INFO where p.Id == lst.ID select p).SingleOrDefault();
                query.NAME = lst.NAME;
                query.ADDRESS = lst.ADDRESS;
                query.BIRTHDAY = lst.BIRTHDAY;
                query.PHONE = lst.PHONE;
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Thêm 1 phục vụ vào danh sách
        public Boolean InsertWaiter(WaiterDTO lst)
        {
            try
            {
                WAITER_INFO newDishType = new WAITER_INFO()
                {
                    Id = Guid.NewGuid(),
                    NAME = lst.NAME,
                    ADDRESS = lst.ADDRESS,
                    BIRTHDAY = lst.BIRTHDAY,
                    PHONE = lst.PHONE
                };

                Context.WAITER_INFO.AddObject(newDishType);
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Xóa 1 phục vụ khỏi danh sách
        public Boolean DeleteWaiter(Guid IDs)
        {
            try
            {
                WAITER_INFO query = (from p in Context.WAITER_INFO where p.Id == IDs select p).SingleOrDefault();

                Context.WAITER_INFO.DeleteObject(query);

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
