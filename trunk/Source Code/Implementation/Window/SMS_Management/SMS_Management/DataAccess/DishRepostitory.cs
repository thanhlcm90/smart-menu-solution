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
