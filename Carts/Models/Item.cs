using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FoodBasket.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
    }

    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public int ItemId { get; set; }
    }

    //[DatabaseGenerated(DatabaseGeneratedOption.None)]


    /* public class Login
     {
         [Key]
         public int Id { get; set; }
         public string UserName { get; set; }
         public string Password { get; set; }
     }*/
}
