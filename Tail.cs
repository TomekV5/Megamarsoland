using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MX3
{
    public class Tail
    {
        private double coal;
        private double iron;
        private double concreat;
        private double water;
        private string name;
        public double Coal
        {
            get { return coal; }
            set { coal = value; }
        }
        public double Iron
        {
            get { return iron; }
            set { iron = value; }
        }
        public double Concreat
        {
            get { return concreat; }
            set { concreat = value; }
        }
        public double Water
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
            Name = ":";
            Coal = 0;
            Iron = 0;
            Concreat = 0;
            Water = 0;
        }
        //public void Introduse()
        //{
        //    Console.WriteLine($"Terain: {this.GetType().Name}");
        //    Console.WriteLine($"-coal: {this.Coal}");
        //    Console.WriteLine($"-iron: {this.Iron}");
        //    Console.WriteLine($"-concreat: {this.Concreat}");
        //    Console.WriteLine($"-water: {this.Water}");
        //}
    }
}
