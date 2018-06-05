using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FoodBasket.Models
{
    public class Login
    {         
            [Required(ErrorMessage = "Please enter your username")]
            [Display(Name = "Username")]
            [MinLength(6, ErrorMessage = "Username should be a minumum if 6 characters")]
            public string Username { get; set; }

            [Required(ErrorMessage = "Please enter your password")]
            [DataType(DataType.Password)]
            [MinLength(5, ErrorMessage = "Password requires a min of 5 characters")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string Password { get; set; }
    }
}