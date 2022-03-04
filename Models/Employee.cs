using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ado_Example2.Models
{
    public class Employee
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter  name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter city.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter address.")]
        public string Address { get; set; }
    }
}