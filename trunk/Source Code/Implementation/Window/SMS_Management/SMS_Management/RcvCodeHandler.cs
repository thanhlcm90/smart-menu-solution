using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS_Management
{
    class RcvCodeHandler
    {
        public static void CodeExtractor(string RcvCode)
        {
            //Received Code AXXYYYZZ
            // Get command code A
            string A = RcvCode.Substring(0, 1);

            // Get table code XX
            string XX = RcvCode.Substring(1, 3);

            // Get dish code YYY
            string YYY = RcvCode.Substring(3, 6);

            // Get quantity ZZ
            string ZZ = RcvCode.Substring(6, 8);
        }

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

        //List ordered dishes
        public List<ORDERED > GetOrdered()
        {
            try
            {
                List<ORDERED> lst = (from p in Context.ORDERED  select p).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Inserted ordered dishes
        public Boolean InsertOrdered(ORDERED lst)
        {
            try
            {
                lst.Id = Guid.NewGuid();
                Context.ORDERED.AddObject(lst);
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
