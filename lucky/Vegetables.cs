using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lucky
{
    public class Vegetables
    {
        public string Naam { get; set; }
        public Vegetables(string naam)
        {
            Naam = naam;
        }
        public override string ToString()
        {
            return Naam;
        }
        
    }

}

