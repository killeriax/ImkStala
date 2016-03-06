using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImkStala.Models
{
    public class User
    {
        public string FirstName { get; set; } //Vardas
        public string LastName { get; set; } //Pavarde
        public string Number { get; set; }
        public string Email { get; set; }

        public User()
        { }
    }
}
