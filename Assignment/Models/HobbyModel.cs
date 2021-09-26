using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentApp.Models
{
    public class HobbyModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "We really need the name of the hobby")]
        [Display(Name = "Hobby")]
        public string Name { get; set; }
    }
}