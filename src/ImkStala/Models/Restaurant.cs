using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImkStala.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; } // atitinka imones koda (?)
        public string Name { get; set; }
        public string VATcode { get; set; } //PVM moketojo kodas
        public string Manager { get; set; }
        public string Adress { get; set; }
        public string Number { get; set; } //telefono numeris
        public string Email { get; set; }
        public string Website { get; set; }
        public string Workhours { get; set; }
        public double Rating { get; set; }

        public Restaurant()
        { }
    }
}
