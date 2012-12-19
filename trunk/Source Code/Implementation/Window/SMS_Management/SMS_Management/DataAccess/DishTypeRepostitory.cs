using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS_Management.Database;
using SMS_Management.DataObject;

namespace SMS_Management
{
    class DishTypeRepostitory : RepostitoryBase
    {
       
        public List<DishTypeDTO> GetDishTypeList()
        {
            try
            {
                List<DishTypeDTO> lst;
                lst = (from p in Context.DISH_TYPE
                       select new DishTypeDTO()
                       {
                           ID = p.Id,
                           NAME=p.NAME
                       }).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean UpdateDishType(DishTypeDTO lst)
        {
            try
            {
                DISH_TYPE query = (from p in Context.DISH_TYPE where p.Id == lst.ID select p).SingleOrDefault();
                query.NAME = lst.NAME;
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Thêm loại món ăn vào danh sách
        public Boolean InsertDishType(DishTypeDTO lst)
        {
            try
            {
                DISH_TYPE newDishType = new DISH_TYPE() { Id = Guid.NewGuid(), NAME = lst.NAME };
              
                Context.DISH_TYPE.AddObject(newDishType);
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Xóa loại món ăn khỏi danh sách
        public Boolean DeleteDishType(Guid IDs)
        {
            try
            {
                DISH_TYPE query = (from p in Context.DISH_TYPE where p.Id == IDs select p).SingleOrDefault();

                Context.DISH_TYPE.DeleteObject(query);

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
