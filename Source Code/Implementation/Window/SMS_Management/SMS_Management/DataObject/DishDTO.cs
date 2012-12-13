using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMS_Management.DataObject
{
    class DishDTO
    {
        private Guid id;
        private string dish_name;
        private string dish_type;
        private string area;
        private string material;
        private string comment;
        private decimal price;
        private int amount;
        private decimal money;

        public Guid ID
        {
            get { return id; }
            set { id = value; }
        }
        public string DISH_NAME
        {
            get { return dish_name; }
            set { dish_name = value; }
        }
        public string DISH_TYPE
        {
            get { return dish_type; }
            set { dish_type = value; }
        }
        public string AREA
        {
            get { return area; }
            set { area = value; }
        }
        public string MATERIAL
        {
            get { return material; }
            set { material = value; }
        }
        public string COMMENT
        {
            get { return comment ; }
            set { comment = value; }
        }
        public int AMOUNT
        {
            get { return amount; }
            set { amount = value; }
        }
        public decimal PRICE
        {
            get { return price; }
            set { price = value; }
        }
        public decimal MONEY
        {
            get { return money; }
            set { money = value; }
        }
    }
}
