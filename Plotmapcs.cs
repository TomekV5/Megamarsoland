using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MX3
{
    public partial class Plotmapcs : Form
    {
        
        //public static int x;
        //public static int y;
        //public static string[,] yourLmap = new string[26, 26];
        //public static string[,] resorsLmap = new string[26, 26];
        public Plotmapcs(TypesLand typesLand)
        {
            InitializeComponent();
            //for (int i = 0; i < tails.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tails.GetLength(1); j++)
            //    {
            //        for (int p = 0; p < tails.GetLength(2); p++)
            //        {
            //            for (int m = 0; m < tails.GetLength(3); m++)
            //            {
            //                if (typesLand.Coal != 0)
            //                {
            //                    tails[i, j, p, m] = new Coal();
            //                    typesLand.Coal--;
            //                }
            //                else if (typesLand.Water != 0)
            //                {
            //                    tails[i, j, p, m] = new Water();
            //                    typesLand.Water--;
            //                }
            //                else if (typesLand.Concreat != 0)
            //                {
            //                    tails[i, j, p, m] = new Concreat();
            //                    typesLand.Concreat--;
            //                }
            //                else if (typesLand.Iron != 0)
            //                {
            //                    tails[i, j, p, m] = new Iron();
            //                    typesLand.Iron--;
            //                }
            //                else tails[i, j, p, m] = new Tail();
            //            }
            //        }
            //    }
            //}
            //Randomize(tails, tails.GetLength(0), tails.GetLength(1), tails.GetLength(2), tails.GetLength(3));
            //for (int i = 0; i < yourLmap.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tails.GetLength(1); j++)
            //    {
            //        yourLmap[i, j] = ":";
            //    }
            //}
            //for (int i = 0; i < resorsLmap.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tails.GetLength(1); j++)
            //    {
            //        resorsLmap[i, j] = yourLmap[i, j];
            //        for (int p = 0; p < tails.GetLength(2); p++)
            //        {
            //            for (int m = 0; m < tails.GetLength(3); m++)
            //            {
            //                if (tails[i, j, p, m].Name != ":") resorsLmap[i, j] = resorsLmap[i, j] + tails[i, j, p, m].Name;
            //            }
            //        }
            //    }
            //}
            string temp = "";
            char t = 'A';
            for (int i = (int)t - 1; i < (int)t + mapOfMars.yourLmap.GetLength(0); i++)
            {
                if (i >= (int)t) temp += (char)i + " ";
                else temp += "";
            }
            temp += "\n";
            string n = "";
            for (int i = 0; i < mapOfMars.yourLmap.GetLength(0); i++)
            {
                n += (i + 1).ToString() + ". ";
                n += "\n";
            }
            label2.Text = n;
            for (int i = 0; i < mapOfMars.yourLmap.GetLength(0); i++)
            {
                for (int j = 0; j < mapOfMars.yourLmap.GetLength(1); j++)
                {
                    temp += mapOfMars.yourLmap[i, j] + " ";
                }
                temp += "\n";
            }
            label1.Text = temp;
        }
        //public static void Randomize(Tail[,,,] arr, int n, int x, int q, int y)
        //{
        //    Random r = new Random();
        //    for (int i = n - 1; i > 0; i--)
        //    {
        //        for (int j = x - 1; j > 0; j--)
        //        {
        //            for (int p = q - 1; p > 0; p--)
        //            {
        //                for (int m = y - 1; m > 0; m--)
        //                {
        //                    int r1 = r.Next(0, i + 1);
        //                    int r2 = r.Next(0, j + 1);
        //                    int r3 = r.Next(0, p + 1);
        //                    int r4 = r.Next(0, m + 1);
        //                    Tail temp = arr[i, j, p, m];
        //                    arr[i, j, p, m] = arr[r1, r2, r3, r4];
        //                    arr[r1, r2, r3, r4] = temp;
        //                }
        //            }
        //        }
        //    }
        //}

        private void rece_Click(object sender, EventArgs e)
        {
            c.Text = "";
            l.Text = "";
        }

        private void next_Click(object sender, EventArgs e)
        {
            char t = 'A';
            if (Regex.IsMatch(c.Text, @"^[A-Z]$") != true || Regex.IsMatch(l.Text, @"^\d+$") != true || int.Parse(l.Text) > mapOfMars.yourLmap.GetLength(0) || int.Parse(l.Text) < 1)
            {
                MessageBox.Show("Incorect coordinate");
            }
            else
            {
                mapOfMars.yourLmap[int.Parse(l.Text) - 1, (int)c.Text[0] - (int)t] = mapOfMars.resorsLmap[int.Parse(l.Text) - 1, (int)c.Text[0] - (int)t];
                resorstext.Text = mapOfMars.yourLmap[int.Parse(l.Text), (int)c.Text[0] - (int)t];
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            char t = 'A';
            Hide();
            mapOfMars.x = int.Parse(l.Text) - 1;
            mapOfMars.y = (int)c.Text[0] - (int)t;
            SmalPlot smalPlot = new SmalPlot(1000);
            smalPlot.ShowDialog();
        }
    }
}
