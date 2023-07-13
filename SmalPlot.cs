using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MX2
{
    public partial class SmalPlot : Form
    {
        public static int mt;
        public static int i;
        public static int co;
        public static int cr;
        public static int w;
        public SmalPlot(int moneytotal, int coal, int iron, int concreat, int water)
        {
            InitializeComponent();
            mt = moneytotal;
            i=iron;
            co=coal;
            cr=concreat;
            w=water;
            money.Text = moneytotal.ToString() + "$";
            menu.Hide();
            comboBox1.Hide();
            comboBox2.Hide();
            comboBox3.Hide();
            comboBox4.Hide();
            comboBox5.Hide();
            comboBox6.Hide();
            comboBox7.Hide();
            comboBox8.Hide();
            a1.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Name.ToString();
            a2.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 1].Name.ToString();
            a3.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 2].Name.ToString();
            b1.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 0].Name.ToString();
            b2.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 1].Name.ToString();
            b3.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 2].Name.ToString();
            c1.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 0].Name.ToString();
            c2.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 1].Name.ToString();
            c3.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 2].Name.ToString();
            ironc.Text=i.ToString()+"I";
            coalc.Text=co.ToString()+"C";
            concreatc.Text=cr.ToString()+"CR";
            waterc.Text=w.ToString()+"W";
        }

        private void a1_Click(object sender, EventArgs e)
        {
            menu.Show();
            if (menu.SelectedItem != null) mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0] = new Building(menu.SelectedItem.ToString());
            mapOfMars.buifingcon++;
            if(i<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Iron&&co<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Coal&&cr<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Concreat&&w<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Water&&mt<=0)
            {
                End end=new End();
                end.ShowDialog();
                Hide();
            }
            if(i<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Iron||co<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Coal||cr<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Concreat||w<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Water)
            {
                MessageBox.Show("You can not do that!");
                mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0] = new Building("");
                mapOfMars.buifingcon--;

            }
            //if(i<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Iron&&co<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Coal&&cr<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Concreat&&w<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Water&&mt<=0)
            //{
            //    End end=new End();
            //    end.ShowDialog();
            //    Hide();
            //}
            a1.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Name.ToString();
            i-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Iron;
            co-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Coal;
            cr-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Concreat;
            w-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 0].Water;
            ironc.Text=i.ToString()+"I";
            coalc.Text=co.ToString()+"C";
            concreatc.Text=cr.ToString()+"CR";
            waterc.Text=w.ToString()+"W";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            comboBox1.Show();
            if (comboBox1.SelectedItem != null) mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 0] = new Building(comboBox1.SelectedItem.ToString());
            mapOfMars.buifingcon++;
            if(i<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 0].Iron||co<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 0].Coal||cr<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 0].Concreat||w<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 0].Water)
            {
                MessageBox.Show("You can not do that!");
                mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 0] = new Building("");
                mapOfMars.buifingcon--;
            }
            if(i<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 0].Iron&&co<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 0].Coal&&cr<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 0].Concreat&&w<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 0].Water&&mt<=0)
            {
                Hide();
                End end=new End();
                end.ShowDialog();
            }
            b1.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 0].Name.ToString();
            i-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 0].Iron;
            co-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 0].Coal;
            cr-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 0].Concreat;
            w-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 0].Water;
            ironc.Text=i.ToString()+"I";
            coalc.Text=co.ToString()+"C";
            concreatc.Text=cr.ToString()+"CR";
            waterc.Text=w.ToString()+"W";
        }

        private void c1_Click(object sender, EventArgs e)
        {
            comboBox2.Show();
            if (comboBox2.SelectedItem != null) mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 0] = new Building(comboBox2.SelectedItem.ToString());
            mapOfMars.buifingcon++;
            if(i<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 0].Iron||co<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 0].Coal||cr<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 0].Concreat||w<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 0].Water)
            {
                MessageBox.Show("You can not do that!");
                mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 0] = new Building("");
                mapOfMars.buifingcon--;
            }
            if(i<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 0].Iron&&co<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 0].Coal&&cr<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 0].Concreat&&w<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 0].Water&&mt<=0)
            {
                Hide();
                End end=new End();
                end.ShowDialog();
            }
            c1.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 0].Name.ToString();
            i-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 0].Iron;
            co-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 0].Coal;
            cr-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 0].Concreat;
            w-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 0].Water;
            ironc.Text=i.ToString()+"I";
            coalc.Text=co.ToString()+"C";
            concreatc.Text=cr.ToString()+"CR";
            waterc.Text=w.ToString()+"W";
        }

        private void a2_Click(object sender, EventArgs e)
        {
            comboBox3.Show();
            if (comboBox3.SelectedItem != null) mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 1] = new Building(comboBox3.SelectedItem.ToString());
            mapOfMars.buifingcon++;
            if(i<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 1].Iron||co<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 1].Coal||cr<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 1].Concreat||w<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0,1].Water)
            {
                MessageBox.Show("You can not do that!");
                mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 1] = new Building("");
                mapOfMars.buifingcon--;
            }
            if(i<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 1].Iron&&co<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 1].Coal&&cr<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 1].Concreat&&w<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 1].Water&&mt<=0)
            {
                Hide();
                End end=new End();
                end.ShowDialog();
            }
            a2.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 1].Name.ToString();
            i-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 1].Iron;
            co-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 1].Coal;
            cr-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 1].Concreat;
            w-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 1].Water;
            ironc.Text=i.ToString()+"I";
            coalc.Text=co.ToString()+"C";
            concreatc.Text=cr.ToString()+"CR";
            waterc.Text=w.ToString()+"W";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            comboBox4.Show();
            if (comboBox4.SelectedItem != null) mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 1] = new Building(comboBox4.SelectedItem.ToString());
            mapOfMars.buifingcon++;
            if(i<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 1].Iron||co<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 1].Coal||cr<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 1].Concreat||w<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 1].Water)
            {
                MessageBox.Show("You can not do that!");
                mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 1] = new Building("");
                mapOfMars.buifingcon--;
            }
            if(i<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 1].Iron&&co<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 1].Coal&&cr<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 1].Concreat&&w<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 1].Water&&mt<=0)
            {
                Hide();
                End end=new End();
                end.ShowDialog();
            }
            b2.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 1].Name.ToString();
            i-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 1].Iron;
            co-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 1].Coal;
            cr-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 1].Concreat;
            w-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 1].Water;
            ironc.Text=i.ToString()+"I";
            coalc.Text=co.ToString()+"C";
            concreatc.Text=cr.ToString()+"CR";
            waterc.Text=w.ToString()+"W";
        }

        private void c2_Click(object sender, EventArgs e)
        {
            comboBox5.Show();
            if (comboBox5.SelectedItem != null) mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 1] = new Building(comboBox5.SelectedItem.ToString());
            mapOfMars.buifingcon++;
            if(i<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 1].Iron||co<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 1].Coal||cr<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 1].Concreat||w<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 1].Water)
            {
                MessageBox.Show("You can not do that!");
                mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 1] = new Building("");
                mapOfMars.buifingcon--;
            }
            if(i<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 1].Iron&&co<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 1].Coal&&cr<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 1].Concreat&&w<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 1].Water&&mt<=0)
            {
                Hide();
                End end=new End();
                end.ShowDialog();
            }
            c2.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 1].Name.ToString();
            i-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 1].Iron;
            co-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 1].Coal;
            cr-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 1].Concreat;
            w-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 1].Water;
            ironc.Text=i.ToString()+"I";
            coalc.Text=co.ToString()+"C";
            concreatc.Text=cr.ToString()+"CR";
            waterc.Text=w.ToString()+"W";
        }

        private void a3_Click(object sender, EventArgs e)
        {
            comboBox6.Show();
            if (comboBox6.SelectedItem != null) mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 2] = new Building(comboBox6.SelectedItem.ToString());
            mapOfMars.buifingcon++;
            if(i<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 2].Iron||co<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 2].Coal||cr<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 2].Concreat||w<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 2].Water)
            {
                MessageBox.Show("You can not do that!");
                mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 2] = new Building("");
                mapOfMars.buifingcon--;
            }
            if(i<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 2].Iron&&co<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 2].Coal&&cr<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 2].Concreat&&w<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 2].Water&&mt<=0)
            {
                Hide();
                End end=new End();
                end.ShowDialog();
            }
            a3.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 2].Name.ToString();
            i-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 2].Iron;
            co-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 2].Coal;
            cr-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 2].Concreat;
            w-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 0, 2].Water;
            ironc.Text=i.ToString()+"I";
            coalc.Text=co.ToString()+"C";
            concreatc.Text=cr.ToString()+"CR";
            waterc.Text=w.ToString()+"W";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            comboBox7.Show();
            if (comboBox7.SelectedItem != null) mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 2] = new Building(comboBox7.SelectedItem.ToString());
            mapOfMars.buifingcon++;
            if(i<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 2].Iron||co<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 2].Coal||cr<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 2].Concreat||w<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 2].Water)
            {
                MessageBox.Show("You can not do that!");
                mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 2] = new Building("");
                mapOfMars.buifingcon--;
            }
            if(i<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 2].Iron&&co<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 2].Coal&&cr<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 2].Concreat&&w<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 2].Water&&mt<=0)
            {
                Hide();
                End end=new End();
                end.ShowDialog();
            }
            b3.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 2].Name.ToString();
            i-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 2].Iron;
            co-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 2].Coal;
            cr-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 2].Concreat;
            w-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 1, 2].Water;
            ironc.Text=i.ToString()+"I";
            coalc.Text=co.ToString()+"C";
            concreatc.Text=cr.ToString()+"CR";
            waterc.Text=w.ToString()+"W";
        }

        private void c3_Click(object sender, EventArgs e)
        {
            comboBox8.Show();
            if (comboBox8.SelectedItem != null) mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 2] = new Building(comboBox8.SelectedItem.ToString());
            mapOfMars.buifingcon++;
            c3.Text = mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 2].Name.ToString();
            if(i<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 2].Iron||co<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 2].Coal||cr<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 2].Concreat||w<mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 2].Water)
            {
                MessageBox.Show("You can not do that!");
                mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 2] = new Building("");
                mapOfMars.buifingcon--;
            }
            if(i<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 2].Iron&&co<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 2].Coal&&cr<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 2].Concreat&&w<=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 2].Water&&mt<=0)
            {
                Hide();
                End end=new End();
                end.ShowDialog();
            }
            i-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 2].Iron;
            co-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 2].Coal;
            cr-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 2].Concreat;
            w-=mapOfMars.tails[mapOfMars.x, mapOfMars.y, 2, 2].Water;
            ironc.Text=i.ToString()+"I";
            coalc.Text=co.ToString()+"C";
            concreatc.Text=cr.ToString()+"CR";
            waterc.Text=w.ToString()+"W";
        }

        private void buy_Click(object sender, EventArgs e)
        {
            Hide();
            Buy buy = new Buy();
            buy.ShowDialog();
        }

        private void explore_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mapOfMars.tails.GetLength(2); i++)
            {
                for (int j = 0; j < mapOfMars.tails.GetLength(3); j++)
                {
                    if (mapOfMars.tails[mapOfMars.x, mapOfMars.y, i, j].Name != ":")
                    {
                        mapOfMars.yourLmap[mapOfMars.x, mapOfMars.y] += mapOfMars.tails[mapOfMars.x, mapOfMars.y, i, j].Name;
                        mapOfMars.resorsLmap[mapOfMars.x, mapOfMars.y] += mapOfMars.tails[mapOfMars.x, mapOfMars.y, i, j].Name;
                    }
                }               
            }
            Hide();
            Plotmapcs bigMap = new Plotmapcs(mt,co,i,cr,w);
            bigMap.ShowDialog();
        }
    }
}
