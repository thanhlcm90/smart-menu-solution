using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS_Management.Database;
using SMS_Management.DataObject;

namespace SMS_Management
{
    class ChefRepostitory : RepostitoryBase
    {
       //Lấy list danh sách đầu bếp

        public List<ChefDTO> GetChefList()
        {
            try
            {
                List<ChefDTO> lst;
                lst = (from p in Context.CHEF_INFO
                       select new ChefDTO()
                       {
                           ID = p.Id,
                           NAME=p.NAME,
                           ADDRESS=p.ADDRESS,
                           BIRTHDAY=p.BIRTHDAY,
                           PHONE=p.PHONE
                       }).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Cập nhật 1 đầu bếp
        public Boolean UpdateChef(ChefDTO lst)
        {
            try
            {
                CHEF_INFO query = (from p in Context.CHEF_INFO where p.Id == lst.ID select p).SingleOrDefault();
                query.NAME = lst.NAME;
                query.ADDRESS=lst.ADDRESS;
                           query.BIRTHDAY=lst.BIRTHDAY;
                           query.PHONE = lst.PHONE;
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Thêm 1 đầu bếp vào danh sách
        public Boolean InsertChef(ChefDTO lst)
        {
            try
            {
                CHEF_INFO newDishType = new CHEF_INFO()
                {
                    Id = Guid.NewGuid(),
                    NAME = lst.NAME,
                    ADDRESS = lst.ADDRESS,
                    BIRTHDAY = lst.BIRTHDAY,
                    PHONE = lst.PHONE
                };

                Context.CHEF_INFO.AddObject(newDishType);
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Xóa 1 đầu bếp khỏi danh sách
        public Boolean DeleteChef(Guid IDs)
        {
            try
            {
                CHEF_INFO query = (from p in Context.CHEF_INFO where p.Id == IDs select p).SingleOrDefault();

                Context.CHEF_INFO.DeleteObject(query);

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
