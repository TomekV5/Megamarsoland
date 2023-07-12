using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MX3
{
    public class TypesLand
    {
        private int coal;
        private int iron;
        private int concreat;
        private int water;
        private string name;
        public int Coal
        {
            get { return coal; }
            set { coal = value; }
        }
        public int Iron
        {
            get { return iron; }
            set { iron = value; }
        }
        public int Concreat
        {
            get { return concreat; }
            set { concreat = value; }
        }
        public int Water
        {
            get { return water; }
            set { water = value; }
        }
        public string Name
        {
            get { return name;}
            set { name = value; }
        }
        public TypesLand()
        {
            this.Name="E";
            Coal = 0;
            Iron = 0;
            Concreat = 0;
            Water = 0;
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
