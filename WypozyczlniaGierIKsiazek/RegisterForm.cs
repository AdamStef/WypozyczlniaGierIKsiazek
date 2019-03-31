using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WypozyczlniaGierIKsiazek
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADAM-PC\HUMANSOFT;Initial Catalog=Users;Integrated Security=True;Pooling=False;");

            if (textBoxLogin.Text != "" || textBoxHaslo.Text != "" || textBoxPHaslo.Text != "") {
                if (textBoxHaslo.Text == textBoxPHaslo.Text)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Users(Username, Password) VALUES ('" + textBoxLogin.Text + "', '" + textBoxHaslo.Text + "');", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Udało ci się zarejestrować!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hasła nie pasują do siebie!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pola nie mogą być puste!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logowanie.EnableForm();
        }
    }
}
