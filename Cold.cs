using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MX2
{
    class Cold:TypesLand
    {
        Random Random = new Random();
        public Cold() 
        {
            this.Name = "C";
            Coal = Random.Next(40, 49);
            Iron = Random.Next(25, 41);
            Concreat = Random.Next(25, 41);
            Water = Random.Next(40, 49);
        }
    }
}
