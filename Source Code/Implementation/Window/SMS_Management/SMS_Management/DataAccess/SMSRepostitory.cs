using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS_Management.Database;

namespace SMS_Management
{
    public class SMSRepostitory
    {
        SMS_DatabaseEntities _ctx;
        public SMS_DatabaseEntities Context
        {
            get
            {
                if (_ctx == null)
                {
                    _ctx = new SMS_DatabaseEntities();
                    _ctx.ContextOptions.LazyLoadingEnabled=true;
                }
                return _ctx;
            }
        }


        //Lấy danh sách nhan vien
        public List<WAITER_INFO> GetWaterInfo()
        {
            try
            {
            
                var alo = from p in Context.WAITER_INFO
                          select p;


                List<WAITER_INFO> y = alo.ToList();
                return y;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Thêm 1 nhân viên mới
        public Boolean InsertWaiter(WAITER_INFO lst)
        {
            try
            {
                lst.Id = Guid.NewGuid();
                Context.WAITER_INFO.AddObject(lst);
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //cập nhật thông tin  nhân viên 
        public Boolean UpdateWaiter(WAITER_INFO lst)
        {
            try
            {
                WAITER_INFO query = (from p in Context.WAITER_INFO where p.Id == lst.Id select p).SingleOrDefault();
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
        //Xoa nhan vien
        public Boolean DeleteWaiter(List<Guid> IDs)
        {
            try
            {
                List<WAITER_INFO> query = (from p in Context.WAITER_INFO where IDs.Contains(p.Id) select p).ToList();
                foreach (WAITER_INFO dt in query)
                {
                    Context.WAITER_INFO.DeleteObject(dt);
                }
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        
        //Lấy danh sách các loại món ăn
        public List<DISH_TYPE> GetDishType()
        {
            try
            {
           
                var alo = from p in Context.DISH_TYPE
                          select p;


                List<DISH_TYPE> y = alo.ToList();
                return y;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Cập nhập loại món ăn vào danh sách
        public Boolean UpdateDishType(DISH_TYPE lst)
        {
            try
            {
                DISH_TYPE query = (from p in Context.DISH_TYPE where p.Id == lst.Id select p).SingleOrDefault();
                query.NAME  = lst.NAME;
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Thêm loại món ăn vào danh sách
        public Boolean InsertDishType(DISH_TYPE lst)
        {
            try
            {
                lst.Id = Guid.NewGuid();
                Context.DISH_TYPE.AddObject(lst);
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Xóa loại món ăn khỏi danh sách
        public Boolean DeleteDishType(List<Guid> IDs)
        {
            try
            {
                List<DISH_TYPE> query = (from p in Context.DISH_TYPE where IDs.Contains(p.Id) select p).ToList();
                foreach (DISH_TYPE dt in query)
                {
                    Context.DISH_TYPE.DeleteObject(dt);
                }
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        //lAY DANH SACH DAU BEP
        public List<CHEF_INFO> GetChefInfo()
        {
            try
            {

                var alo = from p in Context.CHEF_INFO
                          select p;


                List<CHEF_INFO> y = alo.ToList();
                return y;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean InsertCheft(CHEF_INFO lst)
        {
            try
            {
                lst.Id = Guid.NewGuid();
                Context.CHEF_INFO.AddObject(lst);
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //cập nhật thông tin  nhân viên 
        public Boolean UpdateChef(CHEF_INFO lst)
        {
            try
            {
                CHEF_INFO query = (from p in Context.CHEF_INFO where p.Id == lst.Id select p).SingleOrDefault();
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
        //Xoa nhan vien
        public Boolean DeleteChef(List<Guid> IDs)
        {
            try
            {
                List<CHEF_INFO> query = (from p in Context.CHEF_INFO where IDs.Contains(p.Id) select p).ToList();
                foreach (CHEF_INFO dt in query)
                {
                    Context.CHEF_INFO.DeleteObject(dt);
                }
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        //lay danh sach mon an
        public List<DISH> GetDishInfo(Guid IDs)
        {
            try
            {

                var alo = from p in Context.DISH where p.DISHTYPE_ID ==IDs
                          select p;


                List<DISH> y = alo.ToList();
                return y;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public List<TABLES_INFO> GetTableInfo()
        {
            try
            {

                var alo = from p in Context.TABLES_INFO
                          select p;


                List<TABLES_INFO> y = alo.ToList();
                return y;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
