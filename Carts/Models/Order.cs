using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FoodBasket.Models
{
    public class Order
    {
        public int Order_ID { get; set; }
        public int Emp_ID { get; set; }
        public int MenuItemID { get; set; }
        public double Item_Price { get; set; }
        public int Order_Quantity { get; set; }
        public double Item_TotalPrice { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}