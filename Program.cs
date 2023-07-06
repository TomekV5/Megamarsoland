using System;
using System.Text.RegularExpressions;

namespace Marsogrom
{
    class Program
    {
        static void Main(string[] args)
        {
            TypesLand[,] map_on_mars = new TypesLand[26, 26];
            for (int i = 0; i < map_on_mars.GetLength(0); i++)
            {
                for (int j = 0; j < map_on_mars.GetLength(1); j++)
                {
                    map_on_mars[i, j] = new Normal();
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < map_on_mars.GetLength(1); j++)
                {
                    map_on_mars[i, j] = new Cold();
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < map_on_mars.GetLength(1); j++)
                {
                    map_on_mars[map_on_mars.GetLength(0) - i - 1, j] = new Cold();
                }
            }
            for (int i = map_on_mars.GetLength(0)/2-2; i < map_on_mars.GetLength(0) / 2 + 2; i++)
            {
                for (int j = 0; j < map_on_mars.GetLength(1); j++)
                {
                    map_on_mars[map_on_mars.GetLength(0) - i - 1, j] = new Hot();
                }
            }
            char t = 'A';
            for (int i = (int)t-1; i < (int)t + map_on_mars.GetLength(0); i++)
            {
                if(i>= (int)t) Console.Write((char)i+" ");
                else Console.Write("   ");
            }
            Console.WriteLine();
            for (int i = 0; i < map_on_mars.GetLength(0); i++)
            {
                Console.Write("{0,-3}",i+1+" ");
                for (int j = 0; j < map_on_mars.GetLength(1); j++)
                {
                    Console.Write(map_on_mars[i, j].Name+" ");
                }
                Console.WriteLine();
            }
            while(true)
            {
                Console.Write("Chose you location (exsample A/5) - ");
                string test = Console.ReadLine();
                while (!Regex.IsMatch(test, @"^[A-Z]/\d+$"))
                {
                    Console.WriteLine("Try again");
                    test = Console.ReadLine();
                }
                string[] cordinates = test.Split('/');
                map_on_mars[int.Parse(cordinates[1]) - 1, (int)cordinates[0][0] - (int)t].Introduse();
                Console.Write("Press (C) to confirm - ");
                string confirmed= Console.ReadLine();
                if (confirmed == "C" || confirmed == "c") break;
            }        
        }
    }
}