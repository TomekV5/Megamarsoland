using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marsogrom
{
    class Building:Tail
    {
        public Building(string type)
        {
            if (type == "RocketprasPRAS") Name = "R";
            Name = "B";
            Coal = false;
            Iron = false;
            Concreat = false;
            Water = false;
        }
    }
}
