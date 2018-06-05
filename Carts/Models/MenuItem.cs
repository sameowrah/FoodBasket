using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FoodBasket.Models
{
    public class MenuItem
    {
        /*public enum ID
        {
            101, 102, 103, 104, 105
        }
        */
        public int MenuItemID { get; set; }
        public int MenuCatID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Order_ID { get; set; }
        public int Quantity { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public virtual Order Order { get; set; }
        public virtual MenuCategory MenuCategory { get; set; }
    }
}        