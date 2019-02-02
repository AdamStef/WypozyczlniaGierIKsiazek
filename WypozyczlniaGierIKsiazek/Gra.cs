using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczlniaGierIKsiazek
{
    class Gra : ObjektBiblioteki
    {
        public int minWiek;
        public string tytul;

        public Gra(string tytul, int minWiek, decimal cena, string opis)
            : base(cena, opis)
        {
            this.tytul = tytul;
            this.minWiek = minWiek;
        }

        public override string ToString()
        {
            return tytul;
        }

        public void ZapiszDoPliku()
        {
            using (StreamWriter zapisz = new StreamWriter
                (@"D:\informatyka\Programowanie\Dodatkowe\WypozyczlniaGierIKsiazek\gry.txt", true))
            {
                zapisz.WriteLine("{0}|{1}|{2}|{3}", tytul, minWiek, cena, opis);
            }
        }
    }
}
