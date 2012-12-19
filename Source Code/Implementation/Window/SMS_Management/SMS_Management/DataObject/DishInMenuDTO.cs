using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS_Management.DataObject
{
    class DishInMenuDTO 
    {
        public Guid ID {get;set;}
        public int CODE { get; set; }
        public string NAME_VN { get; set; }
        public string NAME_EN { get; set; }
        public decimal PRICE { get; set; }
        public Guid DISHTYPE_ID { get; set; }
     
    }
}
