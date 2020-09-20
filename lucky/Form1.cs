using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lucky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       static List<string> Naamen = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            
           Naamen.Add("Aarthi");
            Naamen.Add("Cat");
            Naamen.Add("Mat");
            Naamen.Add("Hat");
            Naamen.Add("Kalyan");
            listBox1.DataSource = Naamen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shuffle(Naamen);
            listBox1.DataSource = null;
            listBox1.DataSource = Naamen;

        }
            
        public static List<String> Shuffle(List<String> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }

    }

}
