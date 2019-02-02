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
    public partial class NowaKsiazka : Form
    {
        public NowaKsiazka()
        {
            InitializeComponent();
        }

        private void buttonZapiszK_Click(object sender, EventArgs e)
        {
            try
            {
                Ksiazka ksiazka = new Ksiazka(textBoxTytul.Text, textBoxAutor.Text, decimal.Parse(textBoxCena.Text), textBoxOpis.Text, textBoxWyd.Text, int.Parse(textBoxIsbn.Text));
                ksiazka.ZapiszDoPliku();
                Close();
            }
            catch
            {
                MessageBox.Show("Wpisałeś błędne wartości", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonWyczyscK_Click(object sender, EventArgs e)
        {
            textBoxTytul.Text = "";
            textBoxAutor.Text = "";
            textBoxCena.Text = "";
            textBoxOpis.Text = "";
            textBoxWyd.Text = "";
            textBoxIsbn.Text = "";
        }
    }
}
