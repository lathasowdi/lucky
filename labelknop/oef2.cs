using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labelknop
{
    public partial class oef2 : Form
    {
        public oef2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            using (StreamWriter writer = new StreamWriter("${textBox2.Text}.txt"))
            {
                foreach(var item in listBox1.Items)
                {
                    writer.WriteLine(item);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if(!File.Exists("${textBox2.Text}.txt"))
            {
                File.Create("${textBox2.Text}.txt").Dispose();
            }
            using (StreamReader reader = new StreamReader("${textBox2.Text}.txt"))
            {
                while (!reader.EndOfStream)
                {
                   listBox1.Items.Add(reader.ReadLine());
                }
            }
            textBox1.Focus();

        }

        private void oef2_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
