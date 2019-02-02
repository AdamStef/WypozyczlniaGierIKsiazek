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
    public partial class Logowanie : Form
    {
        string login = "admin";
        string password = "qwerty";

        public Logowanie()
        {
            InitializeComponent();
        }

        public void Loguj()
        {
            if (textBoxLogin.Text.Equals(login) && textBoxHaslo.Text.Equals(password))
            {
                Form mainForm = new GlowneOkno();
                mainForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Podałeś złe hasło!");
            }
        }

        private void buttonLoguj_Click(object sender, EventArgs e)
        {
            Loguj();
        }

        private void textBoxHaslo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Loguj();
            }
        }
    }
}
