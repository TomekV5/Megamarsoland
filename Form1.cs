using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace MX3
{
    public partial class mapOfMars : Form
    {
        public static Tail[,,,] tails = new Tail[26, 26, 3, 3];
        public static int x;
        public static int y;
        public static string[,] yourLmap = new string[26, 26];
        public static string[,] resorsLmap = new string[26, 26];
        public static TypesLand typesLand;
        TypesLand[,] map_on_mars = new TypesLand[26, 26];
        public mapOfMars()
        {
            InitializeComponent();
            confirm.Hide();
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
            for (int i = map_on_mars.GetLength(0) / 2 - 2; i < map_on_mars.GetLength(0) / 2 + 2; i++)
            {
                for (int j = 0; j < map_on_mars.GetLength(1); j++)
                {
                    map_on_mars[map_on_mars.GetLength(0) - i - 1, j] = new Hot();
                }
            }
            string temp = "";
            char t = 'A';
            for (int i = (int)t - 1; i < (int)t + map_on_mars.GetLength(0); i++)
            {
                if (i >= (int)t) temp += (char)i + " ";
                else temp += "";
            }
            temp += "\n";
            string n = "";
            for (int i = 0; i < map_on_mars.GetLength(0); i++)
            {
                n += (i + 1).ToString() + ". ";
                n += "\n";
            }
            numbers.Text = n;
            for (int i = 0; i < map_on_mars.GetLength(0); i++)
            {
                for (int j = 0; j < map_on_mars.GetLength(1); j++)
                {
                    temp += map_on_mars[i, j].Name + " ";
                }
                temp += "\n";
            }
            table.Text = temp;
        }
        public static void Randomize(Tail[,,,] arr, int n, int x, int q, int y)
        {
            Random r = new Random();
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = x - 1; j > 0; j--)
                {
                    for (int p = q - 1; p > 0; p--)
                    {
                        for (int m = y - 1; m > 0; m--)
                        {
                            int r1 = r.Next(0, i + 1);
                            int r2 = r.Next(0, j + 1);
                            int r3 = r.Next(0, p + 1);
                            int r4 = r.Next(0, m + 1);
                            Tail temp = arr[i, j, p, m];
                            arr[i, j, p, m] = arr[r1, r2, r3, r4];
                            arr[r1, r2, r3, r4] = temp;
                        }
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void next_Click(object sender, EventArgs e)
        {
            char t = 'A';
            if (Regex.IsMatch(c.Text, @"^[A-Z]$") != true || Regex.IsMatch(l.Text, @"^\d+$") != true || int.Parse(l.Text) > map_on_mars.GetLength(0) || int.Parse(l.Text) < 1)
            {
                MessageBox.Show("Incorect coordinate");
            }
            else
            {
                typesLand = map_on_mars[int.Parse(l.Text) - 1, (int)c.Text[0] - (int)t];
                tpln.Text = typesLand.Name;
                coalc.Text = typesLand.Coal.ToString();
                ironc.Text = typesLand.Iron.ToString();
                concreatc.Text = typesLand.Concreat.ToString();
                waterc.Text = typesLand.Water.ToString();
                confirm.Show();
            }
        }

        private void rece_Click(object sender, EventArgs e)
        {
            c.Text = "";
            l.Text = "";
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            Hide();
            for (int i = 0; i < tails.GetLength(0); i++)
            {
                for (int j = 0; j < tails.GetLength(1); j++)
                {
                    for (int p = 0; p < tails.GetLength(2); p++)
                    {
                        for (int m = 0; m < tails.GetLength(3); m++)
                        {
                            if (typesLand.Coal != 0)
                            {
                                tails[i, j, p, m] = new Coal();
                                typesLand.Coal--;
                            }
                            else if (typesLand.Water != 0)
                            {
                                tails[i, j, p, m] = new Water();
                                typesLand.Water--;
                            }
                            else if (typesLand.Concreat != 0)
                            {
                                tails[i, j, p, m] = new Concreat();
                                typesLand.Concreat--;
                            }
                            else if (typesLand.Iron != 0)
                            {
                                tails[i, j, p, m] = new Iron();
                                typesLand.Iron--;
                            }
                            else tails[i, j, p, m] = new Tail();
                        }
                    }
                }
            }
            Randomize(tails, tails.GetLength(0), tails.GetLength(1), tails.GetLength(2), tails.GetLength(3));
            for (int i = 0; i < yourLmap.GetLength(0); i++)
            {
                for (int j = 0; j < tails.GetLength(1); j++)
                {
                    yourLmap[i, j] = ":";
                }
            }
            for (int i = 0; i < resorsLmap.GetLength(0); i++)
            {
                for (int j = 0; j < tails.GetLength(1); j++)
                {
                    resorsLmap[i, j] = yourLmap[i, j];
                    for (int p = 0; p < tails.GetLength(2); p++)
                    {
                        for (int m = 0; m < tails.GetLength(3); m++)
                        {
                            if (tails[i, j, p, m].Name != ":") resorsLmap[i, j] = resorsLmap[i, j] + tails[i, j, p, m].Name;
                        }
                    }
                }
            }
            Plotmapcs plotmapcs = new Plotmapcs(typesLand);
            plotmapcs.ShowDialog();
            Close();
        }
    }
}