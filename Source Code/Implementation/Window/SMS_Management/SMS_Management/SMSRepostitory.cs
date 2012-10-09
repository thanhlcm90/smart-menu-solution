using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        //Lấy danh sách các loại món ăn
        public List<DISH_TYPE > GetDishType()
        {
            try
            {
                List<DISH_TYPE> lst = (from p in Context.DISH_TYPE select p).ToList();
                return lst;
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

        //Xóa loại món ăn khỏi danh sách
        public Boolean DeleteDishType(List<Guid> IDs)
        {
            try
            {
                List<DISH_TYPE> query = (from p in Context.DISH_TYPE where IDs.Contains(p.Id) select p).ToList();
                foreach (DISH_TYPE dt in query)
                {
                    Context.DeleteObject(dt);
                }
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
