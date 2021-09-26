using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentApp.Models
{
    public class PersonHobbyModel
    {
        public int Id { get; set; }
        public PersonModel Person { get; set; }
        public List<HobbyModel> Hobbies { get; set; } = new List<HobbyModel>();
    }
}