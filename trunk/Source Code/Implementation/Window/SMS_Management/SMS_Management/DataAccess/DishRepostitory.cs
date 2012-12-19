using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS_Management.Database;
using SMS_Management.DataObject;

namespace SMS_Management
{
    class DishRepostitory : RepostitoryBase
    {
       
        public List<DishDTO > GetDishList(Guid order_id)
        {
            try
            {
                List<DishDTO> lst;
                lst = (from p in Context.ORDER_DETAIL
                       where p.ORDER_ID == order_id
                       select new DishDTO()
                       {
                           ID = p.Id,
                           DISH_NAME = p.DISH.NAME_VN,
                           DISH_TYPE = p.DISH.DISH_TYPE.NAME,
                           AREA=p.DISH.AREA,
                           MATERIAL=p.DISH.MATERIAL,
                           AMOUNT=p.AMOUNT,
                           PRICE=p.DISH.PRICE,
                           MONEY=p.AMOUNT*p.DISH.PRICE,
                           COMMENT=p.COMMENT
                       }).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<DishInMenuDTO> GetDishMenuList(Guid DishType)
        {
            try
            {
                List<DishInMenuDTO> lst;
                lst = (from p in Context.DISH
                       where p.DISHTYPE_ID == DishType
                       select new DishInMenuDTO()
                       {
                           ID = p.Id,
                           NAME_VN = p.NAME_VN,
                           NAME_EN = p.NAME_EN,
                      CODE=p.CODE,
                      PRICE=p.PRICE
                      
                    
                       }).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean UpdateDish(DishInMenuDTO lst)
        {
            try
            {
                DISH query = (from p in Context.DISH where p.Id == lst.ID select p).SingleOrDefault();
                query.NAME_VN = lst.NAME_VN;
                query.NAME_EN = lst.NAME_EN;
                query.CODE = lst.CODE;
                query.DISHTYPE_ID = lst.DISHTYPE_ID;
                query.PRICE = lst.PRICE;
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Thêm loại món ăn vào danh sách
        public Boolean InsertDish(DishInMenuDTO lst)
        {
            try
            {
                DISH newd = new DISH { Id = Guid.NewGuid(), NAME_EN = lst.NAME_EN, NAME_VN = lst.NAME_VN, PRICE = lst.PRICE, CODE = lst.CODE, DISHTYPE_ID = lst.DISHTYPE_ID };
                Context.DISH.AddObject(newd);
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Xóa loại món ăn khỏi danh sách
        public Boolean DeleteDish(Guid IDs)
        {
            try
            {
                DISH query = (from p in Context.DISH where p.Id == IDs select p).SingleOrDefault();

                Context.DISH.DeleteObject(query);

                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }






        public bool SaveComment(Guid order_id, string comment)
        {
            ORDER_DETAIL orderdtl = (from p in Context.ORDER_DETAIL
                                     where p.Id == order_id
                                     select p).SingleOrDefault();

            if (order_id == null) return false;
            orderdtl.COMMENT = comment;
            Context.SaveChanges();
            return true;
        }
    }
}
