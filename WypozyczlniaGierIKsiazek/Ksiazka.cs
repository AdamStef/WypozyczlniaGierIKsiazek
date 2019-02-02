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
            using (StreamWriter zapisz = new StreamWriter(@"D:\informatyka\Programowanie\Dodatkowe\WypozyczlniaGierIKsiazek\ksiazki.txt", true))
            {
                zapisz.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}", tytul, autor, cena, opis, wydawnictwo, isbn);
            }
        }
    }
}
