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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oef1 oef = new oef1();
            oef.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            oef2 oef = new oef2();
            oef.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oef3 oef = new oef3();
            oef.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            oef4 oef = new oef4();
            oef.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oef5 oef = new oef5();
            oef.Show();
        }


    }
}
