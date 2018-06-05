using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodBasket.Models
{
    public class Register : Login
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your first name.")]
        [Display(Name = "First Name")]
        public string FName { get; set; }

        [Required(ErrorMessage = "Please enter your last name.")]
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /*[Required(ErrorMessage = "Please enter your employee ID")]
        [Display(Employee ID = "Emp_ID")]
        public string Emp_ID { get; set; }*/
    }
}