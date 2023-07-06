using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marsogrom
{
    class Hot : TypesLand
    {
        Random Random = new Random();
        public Hot()
        {
            this.Name = "H";
            Coal = Random.Next(1, 6); ;
            Iron = Random.Next(8, 14); ;
            Concreat = Random.Next(8, 14);
            Water = Random.Next(1, 4);
        }
    }
}
