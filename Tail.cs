using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marsogrom
{
    class Tail
    {
        private bool coal;
        private bool iron;
        private bool concreat;
        private bool water;
        private string name;
        public bool Coal
        {
            get { return coal; }
            set { coal = value; }
        }
        public bool Iron
        {
            get { return iron; }
            set { iron = value; }
        }
        public bool Concreat
        {
            get { return concreat; }
            set { concreat = value; }
        }
        public bool Water
        {
            get { return water; }
            set { water = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Tail()
        {
            Name = " ";
            Coal = false;
            Iron = false;
            Concreat = false;
            Water = false;
        }
        public void Introduse()
        {
            Console.WriteLine($"Terain: {this.GetType().Name}");
            Console.WriteLine($"-coal: {this.Coal}");
            Console.WriteLine($"-iron: {this.Iron}");
            Console.WriteLine($"-concreat: {this.Concreat}");
            Console.WriteLine($"-water: {this.Water}");
        }
    }
}
