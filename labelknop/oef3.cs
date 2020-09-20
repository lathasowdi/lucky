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
    public partial class oef3 : Form
    {
        public oef3()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                MessageBox.Show($"{textBox1.Text}");
            }
        }

        private void oef3_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
