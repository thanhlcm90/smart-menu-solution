using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS_Management.Database;
using SMS_Management.DataObject;

namespace SMS_Management
{
    class RepostitoryBase
    {

        SMS_DatabaseEntities _ctx;
        public SMS_DatabaseEntities Context
        {
            get
            {
                if (_ctx == null)
                {
                    _ctx = new SMS_DatabaseEntities();
                    _ctx.ContextOptions.LazyLoadingEnabled = true;
                }
                return _ctx;
            }
        }
    }
}
