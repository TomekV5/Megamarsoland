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
    public partial class Buy : Form
    {
        public static int spend;
        public Buy()
        {
            InitializeComponent();
            yourmoneytext.Hide();
            you.Hide();
            totla.Hide();
            tooo.Hide();
            finalmoney.Hide();
            fff.Hide();
            finish.Hide();
            buyyy.Hide();
        }

        private void Buy_Load(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            irontotal.Text = "0$";
            coaltotal.Text = "0$";
            cocreattotal.Text = "0$";
            watertotal.Text = "0$";
            total.Text = "0$";
            numericUpDownIron.Value = 0;
            numericUpDownCoal.Value = 0;
            numericUpDownConcreat.Value = 0;
            numericUpDownWater.Value = 0;
        }

        private void sum_Click(object sender, EventArgs e)
        {
            int sumi = (int)numericUpDownIron.Value * int.Parse(ironmoney.Text);
            int sumco = (int)numericUpDownCoal.Value * int.Parse(coalmoney.Text);
            int sumc = (int)numericUpDownConcreat.Value * int.Parse(concreatmoney.Text);
            int sumw = (int)numericUpDownWater.Value * int.Parse(watermoney.Text);
            irontotal.Text = sumi.ToString() + "$";
            coaltotal.Text = sumco.ToString() + "$";
            cocreattotal.Text = sumc.ToString() + "$";
            watertotal.Text = sumw.ToString() + "$";
            total.Text = (sumi + sumco + sumw + sumc).ToString() + "$";
            spend = sumi + sumco + sumw + sumc;
            buyyy.Show();
        }

        private void buyyy_Click(object sender, EventArgs e)
        {
            yourmoneytext.Show();
            you.Show();
            totla.Show();
            tooo.Show();
            finalmoney.Show();
            fff.Show();
            finish.Show();
            you.Text = SmalPlot.mt.ToString();
            tooo.Text=spend.ToString();
            fff.Text=(SmalPlot.mt-spend).ToString();

        }

        private void finish_Click(object sender, EventArgs e)
        {
            Hide();
            SmalPlot smalPlot = new SmalPlot(int.Parse(fff.Text),SmalPlot.co+(int)numericUpDownCoal.Value,SmalPlot.i+(int)numericUpDownIron.Value, SmalPlot.cr+(int)numericUpDownConcreat.Value,SmalPlot.w+(int)numericUpDownWater.Value);
            smalPlot.ShowDialog();
        }
    }
}
