using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczlniaGierIKsiazek
{
    class Biblioteka
    {
        private List<Gra> listaGier;
        private List<Ksiazka> listaKsiazek;
        static private string plikGry = "gry.txt";
        static private string plikKsiazki = "ksiazki.txt";
        private string pathGry = Path.Combine(Environment.CurrentDirectory, @"Files\", plikGry);
        private string pathKsiazki = Path.Combine(Environment.CurrentDirectory, @"Files\", plikKsiazki);

        public Biblioteka()
        {
            listaGier = new List<Gra>();
            listaKsiazek = new List<Ksiazka>();
        }

        public void DodajGreDoListy(Gra gra)
        {
            if (!listaGier.Contains(gra))
            {
                listaGier.Add(gra);
            }
        }

        public void DodajKsiazkeDoListy(Ksiazka ksiazka)
        {
            if (!listaKsiazek.Contains(ksiazka))
            {
                listaKsiazek.Add(ksiazka);
            }
        }

        public void UsunGre(Gra gra)
        {
            listaGier.Remove(gra);
            ZapiszGryDoPliku();
        }

        public void UsunKsiazke(Ksiazka ksiazka)
        {
            listaKsiazek.Remove(ksiazka);
            ZapiszKsiazkiDoPliku();
        }

        public List<Gra> ZaladujGry()
        {
            return listaGier;
        }

        public List<Ksiazka> ZaladujKsiazki()
        {
            return listaKsiazek;
        }

        public void ImportujGryZPliku()
        {
            listaGier.Clear();
            //using (StreamReader wczytaj = new StreamReader(@"D:\informatyka\Programowanie\Dodatkowe\WypozyczlniaGierIKsiazek\gry.txt"))
            using (StreamReader wczytaj = new StreamReader(pathGry))
            {
                string linia;
                while ((linia = wczytaj.ReadLine()) != null)
                {
                    string[] parametry = linia.Split('|');
                    Gra gra = new Gra(parametry[0], int.Parse(parametry[1]), decimal.Parse(parametry[2]), parametry[3]);
                    DodajGreDoListy(gra);
                }
            }
        }

        public void ImportujKsiazkiZPliku()
        {
            listaKsiazek.Clear();
            using (StreamReader wczytaj = new StreamReader(pathKsiazki))
            {
                string linia;
                while ((linia = wczytaj.ReadLine()) != null)
                {
                    string[] parametry = linia.Split('|');
                    Ksiazka ksiazka = new Ksiazka(parametry[0], parametry[1], decimal.Parse(parametry[2]), parametry[3], parametry[4], int.Parse(parametry[5]));
                    DodajKsiazkeDoListy(ksiazka);
                }
            }
        }

        private void ZapiszGryDoPliku()
        {
            using (StreamWriter zapisz = new StreamWriter(pathGry))
            {
                foreach (Gra gra in listaGier)
                {
                    zapisz.WriteLine("{0}|{1}|{2}|{3}", gra.tytul, gra.minWiek, gra.cena, gra.opis);
                }
            }
        }

        private void ZapiszKsiazkiDoPliku()
        {
            using (StreamWriter zapisz = new StreamWriter(pathKsiazki))
            {
                foreach (Ksiazka ksiazka in listaKsiazek)
                {
                    zapisz.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}", ksiazka.tytul, ksiazka.autor, ksiazka.cena, ksiazka.opis, ksiazka.wydawnictwo, ksiazka.isbn);
                }
            }
        }
    }
}
