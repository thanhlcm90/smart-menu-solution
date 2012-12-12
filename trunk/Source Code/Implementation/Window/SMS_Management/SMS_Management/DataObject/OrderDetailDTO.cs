using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS_Management.DataObject
{
    class OrderDetailDTO
    {
        private string table_name;
        private int request_count;
        private int proccess_count;
        private string waiter_name;
        private string chef_name;
        private DateTime? add_time;
        private string status;

        public string TABLE_NAME {
            get {return table_name;}
            set { table_name = value; }
        }
        public int REQUEST_COUNT{
            get { return request_count; }
            set { request_count = value; }
        }
        public int PROCCESSING_COUNT{
            get { return proccess_count; }
            set { proccess_count = value; }
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
