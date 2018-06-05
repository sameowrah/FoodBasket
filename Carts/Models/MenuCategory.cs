using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FoodBasket.Models
{
    public class MenuCategory
    {
        public int MenuCatID { get; set; }
        public string Cat_Name { get; set; }
        public int Order_ID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public virtual ICollection<MenuItem> Enrollments { get; set; }
    }

}