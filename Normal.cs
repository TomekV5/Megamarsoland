using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marsogrom
{
    class Normal:TypesLand
    {
        Random Random = new Random();
        public Normal() 
        {
            this.Name = "N";
            Coal = Random.Next(5, 9);
            Iron = Random.Next(5, 9);
            Concreat = Random.Next(5, 9);
            Water = Random.Next(5, 9);
        }
    }
}
