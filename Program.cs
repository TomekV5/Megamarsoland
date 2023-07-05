using System;

namespace Marsogrom
{

    // TEST
    class Program
    {
        static void Main(string[] args)
        {
            string[,] map_on_mars= new string[25,25];
            for(int i=0;i<map_on_mars.GetLength(0);i++)
            {
                for(int j=0;j<map_on_mars.GetLength(1);j++)
                {
                    map_on_mars[i,j]="N";
                }
            } 
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<map_on_mars.GetLength(1);j++)
                {
                    map_on_mars[i,j]="S";
                }
            }
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<map_on_mars.GetLength(1);j++)
                {
                    map_on_mars[map_on_mars.GetLength(0)-i-1,j]="S";
                }
            }
            char t ='A';
            for(int i=(int)t;i<(int)t+25;i++)
            {
                Console.Write((char)i);
            }
            Console.WriteLine();
            for(int i=0;i<map_on_mars.GetLength(0);i++)
            {
                for(int j=0;j<map_on_mars.GetLength(1);j++)
                {
                    Console.Write(map_on_mars[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
