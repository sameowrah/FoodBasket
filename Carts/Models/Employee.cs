using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FoodBasket.Models
{
    public class Employee
    {
        public int Emp_ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public virtual ICollection<Order> Orders { get; set; }
    }
}