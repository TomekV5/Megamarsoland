using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MX2
{
    public partial class Plotmapcs : Form
    {
        public static int mt;
        public static int i;
        public static int co;
        public static int cr;
        public static int w;
        public Plotmapcs(int money, int coal, int iron, int concreat, int water)
        {
            InitializeComponent();
            mt = money;
            i=iron;
            co=coal;
            cr=concreat;
            w=water;
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
            numbers.Text = n;
            for (int i = 0; i < mapOfMars.yourLmap.GetLength(0); i++)
            {
                for (int j = 0; j < mapOfMars.yourLmap.GetLength(1); j++)
                {
                    temp += mapOfMars.yourLmap[i, j] + " ";
                }
                temp += "\n";
            }
            table.Text = temp;
            ironc.Text=i.ToString()+"I";
            coalc.Text=co.ToString()+"C";
            concreatc.Text=cr.ToString()+"CR";
            waterc.Text=w.ToString()+"W";
        }

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
            SmalPlot smalPlot = new SmalPlot(mt,co,i,cr,w);
            smalPlot.ShowDialog();
        }
    }
}
