using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS_Management.DataObject
{
    class TableDTO
    {
        public int code { get; set; }
        
        public Guid ID { get; set; }
        public string NAME { get; set; }
        public string WaiterName { get; set; }
     
    }
}
