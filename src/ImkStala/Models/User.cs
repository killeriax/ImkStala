using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImkStala.Models
{
    public class User
    {
        public string FName { get; set; } //Vardas
        public string LName { get; set; } //Pavarde
        public string Number { get; set; }
        public string Email { get; set; }

        public User()
        { }
    }
}
