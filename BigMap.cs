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
    public partial class BigMap : Form
    {
        public static int mt;
        public BigMap(int money)
        {
            InitializeComponent();
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
            mt = money;
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
            Hide();
            SmalPlot smalPlot = new SmalPlot(mt);
            smalPlot.Show();
        }
    }
}
