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
    public partial class oef5 : Form
    {
        public oef5()
        {
            InitializeComponent();
        }
        Lijst oef = new Lijst();
        private void oef5_Load(object sender, EventArgs e)
        {
            persoon persoon1 = new persoon("Ken", "Field",24);
            persoon persoon2 = new persoon("Latha", "Sowdi", 36);
            persoon persoon3 = new persoon("Saravana", "Kumar", 40);
            persoon persoon4 = new persoon("Vasuki", "Sowdi", 57);
            persoon persoon5 = new persoon("Atchaya", "SaravanKumar", 11);
            persoon persoon6 = new persoon("Bhavana", "SaravanaKumar", 7);
           oef.PersoonLijst.Add(persoon1);
            oef.PersoonLijst.Add(persoon2);
            oef.PersoonLijst.Add(persoon3);
            oef.PersoonLijst.Add(persoon4);
            oef.PersoonLijst.Add(persoon5);
            oef.PersoonLijst.Add(persoon6);
            listBox1.DataSource = oef.PersoonLijst;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*label1.Text ="ACHTERNAAM:"+ oef.PersoonLijst[listBox1.SelectedIndex].Achternaam+"\n"+
                "LEEFTIJD:" + oef.PersoonLijst[listBox1.SelectedIndex].LeefTijd.ToString();*/
            if (listBox1.SelectedIndex < 0)
            {
               listBox1.SelectedIndex = 0;
            }
           persoon selected = (persoon)listBox1.SelectedItem;

            if (listBox1.DataSource != null)
            {
                label1.Text = selected.Bekijken();
                
            }
            else
            {
                label1.Text = "";
            }

        }
    }
}
