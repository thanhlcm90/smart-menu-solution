using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS_Management.DataObject
{
    class WaiterDTO
    {
        private Guid id;
        private string name;
        private DateTime? birthday;
        private string phone;
        private string address;

        public Guid ID
        {
            get { return id; }
            set { id = value; }
        }
        public string NAME{
            get { return name; }
            set { name = value; }
        }
        public DateTime? BIRTHDAY
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string PHONE{
            get { return phone; }
            set { phone = value; }
        }
        public string ADDRESS{
            get { return address; }
            set { address = value; }
        }
    }
}
