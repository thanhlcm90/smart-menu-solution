using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS_Management.DataObject
{
    class OrderDetailDTO
    {
        private Guid id;
        private Guid dish_id;
        private string dish_name;
        private string dish_type_name;
        private Guid? chef_id;
        private string area;
        private string materia;
        private decimal price;
        private int amount;
        private decimal money;
        private string status;
        private short table_code;

        public Guid ID
        {
            get {return id;}
            set { id = value; }
        }
        public Guid DISH_ID
        {
            get { return dish_id; }
            set { dish_id = value; }
        }
        public Guid? CHEF_ID
        {
            get { return chef_id; }
            set { chef_id = value; }
        }
        public string DISH_NAME{
            get { return dish_name; }
            set { dish_name = value; }
        }
        public string DISH_TYPE_NAME{
            get { return dish_type_name; }
            set { dish_type_name = value; }
        }
        public string AREA{
            get { return area; }
            set { area = value; }
        }
        public string MATERIA{
            get { return materia; }
            set { materia = value; }
        }
        public decimal PRICE
        {
            get { return price; }
            set { price = value; }
        }
        public int AMOUNT
        {
            get { return amount; }
            set { amount = value; }
        }
        public decimal MONEY
        {
            get { return money; }
            set { money = value; }
        }
        public string STATUS
        {
            get { return status; }
            set { status = value; }
        }
        public short TABLE_CODE
        {
            get { return table_code; }
            set { table_code = value; }
        }
    }
}
