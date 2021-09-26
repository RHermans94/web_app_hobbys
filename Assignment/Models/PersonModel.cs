using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssignmentApp.Models
{
    public class PersonModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "We really need a first name.")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "We really need a last name.")]
        [Display(Name = "Last name")]

        public string LastName { get; set; }


        [Display(Name = "Last name prefixes")]
        public string LastNamePrefix { get; set; }
    }
}