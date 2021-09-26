using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class PersonHobbyModel
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int HobbyId { get; set; }
    }
}
