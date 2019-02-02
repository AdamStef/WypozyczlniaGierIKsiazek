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
    public partial class GlowneOkno : Form
    {
        private Biblioteka mojaBibliotekaGier;
        private Biblioteka mojaBibliotekaKsiazek;

        public GlowneOkno()
        {
            InitializeComponent();
            mojaBibliotekaGier = new Biblioteka();
            mojaBibliotekaGier.ImportujGryZPliku();
            listBoxListaGier.DataSource = mojaBibliotekaGier.ZaladujGry();
            mojaBibliotekaKsiazek = new Biblioteka();
            mojaBibliotekaKsiazek.ImportujKsiazkiZPliku();
            listBoxListaKsiazek.DataSource = mojaBibliotekaKsiazek.ZaladujKsiazki();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            NowaGra nowaGra = new NowaGra();
            nowaGra.ShowDialog();
            mojaBibliotekaGier.ImportujGryZPliku();
            listBoxListaGier.DataSource = null;
            listBoxListaGier.DataSource = mojaBibliotekaGier.ZaladujGry();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            mojaBibliotekaGier.UsunGre(listBoxListaGier.SelectedItem as Gra);
            listBoxListaGier.DataSource = null;
            listBoxListaGier.DataSource = mojaBibliotekaGier.ZaladujGry();
        }

        private void buttonDodajKsiazke_Click(object sender, EventArgs e)
        {
            NowaKsiazka nowaKsiazka = new NowaKsiazka();
            nowaKsiazka.ShowDialog();
            mojaBibliotekaKsiazek.ImportujKsiazkiZPliku();
            listBoxListaKsiazek.DataSource = null;
            listBoxListaKsiazek.DataSource = mojaBibliotekaKsiazek.ZaladujKsiazki();
        }

        private void buttonUsunKsiazke_Click(object sender, EventArgs e)
        {
            mojaBibliotekaKsiazek.UsunKsiazke(listBoxListaKsiazek.SelectedItem as Ksiazka);
            listBoxListaKsiazek.DataSource = null;
            listBoxListaKsiazek.DataSource = mojaBibliotekaKsiazek.ZaladujKsiazki();
        }
    }
}
