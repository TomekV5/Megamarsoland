using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MX3
{
    class Building:Tail
    {
        private double output_power;
        private double input_power;
        public double Output_Power
        {
            get { return output_power; }
            set { output_power = value; }
        }
        public double Input_power
        {
            get { return input_power; }
            set { input_power = value; }
        }
        public Building(string type)
        {           
            if (type == "Rocket")
            {
                Name = "🚀";
                Coal = 20;
                Iron = 15;
                Concreat = 0;
                Water = 20;
                Input_power = 0;
                Output_Power = 5;
            }
            else if (type == "Solar Panel")
            {
                Name = "☀";
                Coal = 0;
                Iron = 5;
                Concreat = 0;
                Water = 2;
                Input_power = 0;
                Output_Power = 5;
            }
            else if (type == "Batery")
            {
                Name = "🔋";
                Coal = 0;
                Iron = 10;
                Concreat = 15;
                Water = 0;
                Input_power = 0;
                Output_Power = 0;
            }
            else if (type == "Improve")
            {
                Name = "🏭";
                Coal = 10;
                Iron = 10;
                Concreat = 20;
                Water = 10;
                Input_power = 20;
                Output_Power = 0;
            }
            else if (type == "Storage")
            {
                Name = "⌂";
                Coal = 0;
                Iron = 10;
                Concreat = 20;
                Water = 0;
                Input_power = 10;
                Output_Power = 0;
            }
            else
            {
                Name = "🏝";
                Coal = 0;
                Iron = 0;
                Concreat = 0;
                Water = 0;
                Input_power = 0;
                Output_Power = 0;
            }
        }
    }
}
