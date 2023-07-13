using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MX2
{
    class Normal:TypesLand
    {
        Random Random = new Random();
        public Normal() 
        {
            this.Name = "N";
            Coal = Random.Next(30, 41);
            Iron = Random.Next(30, 41);
            Concreat = Random.Next(30, 41);
            Water = Random.Next(30, 41);
        }
    }
}
