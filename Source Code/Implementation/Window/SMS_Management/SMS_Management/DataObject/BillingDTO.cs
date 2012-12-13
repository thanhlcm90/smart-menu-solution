using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS_Management.DataObject
{
    class BillingDTO
    {
        private Guid id;
        private Guid table_id;
        private string table_name;
        private int request_count;
        private string waiter_name;
        private string chef_name;
        private DateTime? sell_date;
        private string status;
        private decimal money;

        public Guid ID
        {
            get { return id; }
            set { id = value; }
        }
        public Guid TABLE_ID
        {
            get { return table_id; }
            set { table_id = value; }
        }
        public string TABLE_NAME
        {
            get { return table_name; }
            set { table_name = value; }
        }
        public int REQUEST_COUNT
        {
            get { return request_count; }
            set { request_count = value; }
        }
        public string WAITER_NAME
        {
            get { return waiter_name; }
            set { waiter_name = value; }
        }
        public string CHEF_NAME
        {
            get { return chef_name; }
            set { chef_name = value; }
        }
        public DateTime? SELL_DATE
        {
            get { return sell_date; }
            set { sell_date = value; }
        }
        public string STATUS
        {
            get { return status; }
            set { status = value; }
        }
        public decimal MONEY
        {
            get { return money; }
            set { money = value; }
        }
    }
}
