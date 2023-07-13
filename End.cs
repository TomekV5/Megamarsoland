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
    public partial class End : Form
    {
        public End()
        {
            InitializeComponent();
            score.Text = mapOfMars.buifingcon.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            mapOfMars mapOfMars = new mapOfMars();
            mapOfMars.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
