using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS_Management.DataObject
{
    class ProccessingDTO
    {
        private Guid id;
        private Guid table_id;
        private string table_name;
        private string chef_name;
        private string dish_name;
        private int amount;
        private string status;
        private string comment;
        private int priority;

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
        public string CHEF_NAME
        {
            get { return chef_name; }
            set { chef_name = value; }
        }
        public string DISH_NAME
        {
            get { return dish_name; }
            set { dish_name = value; }
        }
        public int AMOUNT
        {
            get { return amount; }
            set { amount = value; }
        }
        public int PRIORITY
        {
            get { return priority ; }
            set { priority = value; }
        }
        public string STATUS
        {
            get { return status; }
            set { status = value; }
        }
        public string COMMENT
        {
            get { return comment ; }
            set { comment = value; }
        }
    }
}
