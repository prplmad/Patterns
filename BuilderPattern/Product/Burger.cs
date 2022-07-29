using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Product
{
    public class Burger
    {
        public string? Size { get; set; }
        public string? BurgerType { get; set; }
        public bool Onion { get; set; }
        public bool Tomatoo { get; set; }
        public bool Cheese { get; set; }
        public bool BeefCutlet { get; set; }
        public bool ChickenCutlet { get; set; }
        public bool Jalapeno { get; set; }
        public bool Sauce { get; set; }

    }
}
