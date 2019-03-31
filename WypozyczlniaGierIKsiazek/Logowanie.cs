using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WypozyczlniaGierIKsiazek
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
            Form form = new Form();
        }

        public void Loguj()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADAM-PC\HUMANSOFT;Initial Catalog=Users;Integrated Security=True;Pooling=False;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Users WHERE Username='" + textBoxLogin.Text + "'AND Password='" + textBoxHaslo.Text +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows[0][0].ToString() == "1")
            {
                Form mainForm = new GlowneOkno();
                mainForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Zły login lub hasło!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Form register = new RegisterForm();
            register.Show();
        }

        public static void EnableForm()
        {
            
        }
    }
}
