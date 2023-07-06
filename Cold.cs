using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marsogrom
{
    class Cold:TypesLand
    {
        Random Random = new Random();
        public Cold() 
        {
            this.Name = "C";
            Coal = Random.Next(8, 14);
            Iron = Random.Next(1, 6);
            Concreat = Random.Next(1, 6);
            Water = Random.Next(8, 14);
        }
    }
}
