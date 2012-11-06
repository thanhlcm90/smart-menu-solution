using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS_Management.DataObject
{
    class OrderDTO
    {
        private string table_name;
        private string dish_name;
        private int dish_amount;
        private string waiter_name;
        private string chef_name;
        private DateTime? add_time;
        private string status;

        public string TABLE_NAME {
            get {return table_name;}
            set { table_name = value; }
        }
        public string DISH_NAME{
            get {return dish_name;}
            set { dish_name = value; }
        }
        public int DISH_AMOUNT{
            get {return dish_amount;}
            set { dish_amount = value; }
        }
        public string WAITER_NAME{
            get {return waiter_name;}
            set { waiter_name = value; }
        }
        public string CHEF_NAME{
            get {return chef_name;}
            set { chef_name = value; }
        }
        public DateTime? ADD_TIME{
            get {return add_time;}
            set { add_time = value; }
        }
        public string STATUS{
            get {return status;}
            set { status = value; }
        }
    }
}
