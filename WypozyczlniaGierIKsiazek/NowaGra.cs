using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WypozyczlniaGierIKsiazek
{
    public partial class NowaGra : Form
    {
        public NowaGra()
        {
            InitializeComponent();
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                Gra gra = new Gra(textBoxTytul.Text, int.Parse(textBoxMinWiek.Text), decimal.Parse(textBoxCena.Text), textBoxOpis.Text);
                gra.ZapiszDoPliku();
                Close();
            }
            catch
            {
                MessageBox.Show("Wpisałeś błędne wartości", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            textBoxTytul.Text = "";
            textBoxOpis.Text = "";
            textBoxCena.Text = "";
            textBoxMinWiek.Text = "";
        }
    }
}
