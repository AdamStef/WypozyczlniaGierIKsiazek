using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczlniaGierIKsiazek
{
    class Ksiazka : ObjektBiblioteki
    {
        public string autor;
        public string wydawnictwo;
        public string tytul;
        public int isbn;
        static private string plikKsiazki = "ksiazki.txt";
        private string pathKsiazki = Path.Combine(Environment.CurrentDirectory, @"Files\", plikKsiazki);

        public Ksiazka(string tytul, string autor, decimal cena, string opis, string wydawnictwo, int isbn)
            : base(cena, opis)
        {
            this.tytul = tytul;
            this.autor = autor;
            this.wydawnictwo = wydawnictwo;
            this.isbn = isbn;
        }

        public override string ToString()
        {
            return tytul;
        }

        public void ZapiszDoPliku()
        {
            using (StreamWriter zapisz = new StreamWriter(pathKsiazki, true))
            {
                zapisz.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}", tytul, autor, cena, opis, wydawnictwo, isbn);
            }
        }
    }
}
