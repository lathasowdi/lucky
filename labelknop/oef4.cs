using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labelknop
{
    public partial class oef4 : Form
    {
        public oef4()
        {
            InitializeComponent();
        }
        tafel oef;
        private void button1_Click(object sender, EventArgs e)
        {
            /* for(int i=1;i<=10;i++)
             {
                 MessageBox.Show($"{numericUpDown1.Value * i}");
             }*/
            /* int inputNumber = 6;

             for (int i = 2; i <= inputNumber; i++)
             {
                 textBox1.Text += i.ToString() + '\t';


                 for (int j = 2; j <= inputNumber; j++)
                 {
                     textBox1.Text += (i * j).ToString() + '\t';
                 }
                 textBox1.Text += Environment.NewLine;
             }*/
            oef = new tafel();
            oef.Show();
           oef.button1.Click += new EventHandler(button2_Click);
        }

        private void oef4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int j = 1; j <= oef.numericUpDown1.Value; j++)
            {
                textBox1.Text += (oef.numericUpDown1.Value * j).ToString() + '\t';
            }
           
        }
    }
}
