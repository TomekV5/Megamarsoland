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
            Iron = Random.Next(40, 49); ;
            Concreat = Random.Next(40, 49);
            Water = Random.Next(25, 31);
        }
    }
}
