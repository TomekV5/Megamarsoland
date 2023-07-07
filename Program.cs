using System;
using System.Text.RegularExpressions;

namespace Marsogrom
{
    class Program
    {
        public static void Randomize(Tail [,,,]arr, int n, int x, int q, int y)
        {
            Random r = new Random();
            for(int i = n - 1; i > 0; i--)
            {
                int r1 = r.Next(0, i+1);
                for(int j = x - 1; j > 0; j--)
                {
                    int r2 = r.Next(0, j+1);
                    for(int p = q - 1; p > 0; p--)
                    {
                        int r3 = r.Next(0, p+1);
                        for(int m = y - 1; m > 0; m--)
                        {
                            int r4 = r.Next(0, m+1);
                            Tail temp = arr[i,j,p,m];
                            arr[i,j,p,m] = arr[r1,r2,r3,r4];
                            arr[r1,r2,r3,r4] = temp;
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            TypesLand typesLand;
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
                if (confirmed == "C" || confirmed == "c") 
                {
                    typesLand=map_on_mars[int.Parse(cordinates[1]) - 1, (int)cordinates[0][0] - (int)t];
                    break;
                }
            }
            Tail[,,,] tails=new Tail[26,26,3,3];
            for(int i=0;i<tails.GetLength(0);i++)
            {
                for(int j=0;j<tails.GetLength(1);j++)
                {
                    for(int p=0;p<tails.GetLength(2);p++)
                    {
                        for(int m=0;m<tails.GetLength(3);m++)
                        {
                            if(typesLand.Coal!=0)
                            {
                                tails[i,j,p,m]=new Coal();
                                typesLand.Coal--;
                            }
                            else if(typesLand.Water!=0)
                            {
                                tails[i,j,p,m]=new Water();
                                typesLand.Water--;
                            }
                            else if(typesLand.Concreat!=0)
                            {
                                tails[i,j,p,m]=new Concreat();
                                typesLand.Concreat--;
                            }
                            else if(typesLand.Iron!=0)
                            {
                                tails[i,j,p,m]=new Iron();
                                typesLand.Iron--;
                            }
                            else tails[i,j,p,m]=new Tail();
                        }
                    }
                }
            }
            Console.WriteLine("Original");
            //for(int i=0;i<tails.GetLength(0);i++)
            //{
            //    for(int j=0;j<tails.GetLength(1);j++)
            //    {
            //        for(int p=0;p<tails.GetLength(2);p++)
            //        {
            //            for(int m=0;m<tails.GetLength(3);m++)
            //            {
            //                Console.Write(tails[i,j,p,m].Name+" ");
            //            }
            //            Console.WriteLine();
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}
            Randomize (tails, tails.GetLength(0), tails.GetLength(1),tails.GetLength(2),tails.GetLength(3));
            //Console.WriteLine("Random");
            //for(int i=0;i<tails.GetLength(0);i++)
            //{
            //    for(int j=0;j<tails.GetLength(1);j++)
            //    {
            //        for(int p=0;p<tails.GetLength(2);p++)
            //        {
            //            for(int m=0;m<tails.GetLength(3);m++)
            //            {
            //                Console.Write(tails[i,j,p,m].Name+" |");
            //            }                       
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}
            while(true)
            {
                for (int i = (int)t-1; i < (int)t + tails.GetLength(0); i++)
                {
                    if(i>= (int)t) Console.Write((char)i+" ");
                    else Console.Write("   ");
                }
                Console.WriteLine();
                for (int i = 0; i < tails.GetLength(0); i++)
                {
                    Console.Write("{0,-3}",i+1+" ");
                    for (int j = 0; j < tails.GetLength(1); j++)
                    {
                        Console.Write(map_on_mars[i, j].Name+" ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
