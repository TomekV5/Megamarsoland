using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MX2
{
    class Building:Tail
    {        
        public Building(string type)
        {           
            if (type == "Rocket")
            {
                Name = "🚀";
                Coal = 20;
                Iron = 15;
                Concreat = 0;
                Water = 20;
            }
            else if (type == "Solar Panel")
            {
                Name = "☀";
                Coal = 0;
                Iron = 5;
                Concreat = 0;
                Water = 2;
            }
            else if (type == "Batery")
            {
                Name = "🔋";
                Coal = 0;
                Iron = 10;
                Concreat = 15;
                Water = 0;
            }
            else if (type == "Improve")
            {
                Name = "🏭";
                Coal = 10;
                Iron = 10;
                Concreat = 20;
                Water = 10;
            }
            else if (type == "Storage")
            {
                Name = "⌂";
                Coal = 0;
                Iron = 10;
                Concreat = 20;
                Water = 0;
            }
            else
            {
                Name = ":";
                Coal = 0;
                Iron = 0;
                Concreat = 0;
                Water = 0;
            }
        }
    }
}
