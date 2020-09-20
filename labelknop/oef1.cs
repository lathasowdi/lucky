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
    public partial class oef1 : Form
    {
        public oef1()
        {
            InitializeComponent();
        }
        teller mijntell = new teller();
       
        private void button1_Click(object sender, EventArgs e)
        {
            mijntell.tellerplus();
            Displaylabel();
        }
       public void Displaylabel()
        {
            label1.Text = mijntell.mijnteller.ToString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mijntell.tellermin();
            Displaylabel();
        }
    }
}
