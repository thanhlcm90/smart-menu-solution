using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS_Management.Database;
using SMS_Management.DataObject;

namespace SMS_Management
{
    class TableRepostitory : RepostitoryBase
    {
        
        public List<TableDTO> GetTableList()
        {
            try
            {
                List<TableDTO> lst;
                lst = (from p in Context.TABLES_INFO
                       select new TableDTO()
                       {
                           ID = p.Id,
                           NAME=p.NAME,
                           code=p.CODE,
                           WaiterName = p.WAITER_INFO.NAME
                       }).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean UpdateTable(TableDTO lst)
        {
            try
            {
                TABLES_INFO query = (from p in Context.TABLES_INFO where p.Id == lst.ID select p).SingleOrDefault();
                query.NAME = lst.NAME;
                query.CODE = lst.code;
                query.WAITER_ID=(from a in Context.WAITER_INFO where a.NAME==lst.WaiterName select a.Id).SingleOrDefault();
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Thêm loại món ăn vào danh sách
        public Boolean InsertTable(TableDTO lst)
        {
            try
            {
                TABLES_INFO newDishType = new TABLES_INFO() { Id = Guid.NewGuid(), NAME = lst.NAME, CODE = lst.code, WAITER_ID = (from a in Context.WAITER_INFO where a.NAME == lst.WaiterName select a.Id).SingleOrDefault() };

                Context.TABLES_INFO.AddObject(newDishType);
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Xóa loại món ăn khỏi danh sách
        public Boolean DeleteTable(Guid IDs)
        {
            try
            {
                TABLES_INFO query = (from p in Context.TABLES_INFO where p.Id == IDs select p).SingleOrDefault();

                Context.TABLES_INFO.DeleteObject(query);

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
