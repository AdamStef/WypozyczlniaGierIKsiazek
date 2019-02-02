using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczlniaGierIKsiazek
{
    class ObjektBiblioteki
    {
        public decimal cena;
        public string opis;

        public ObjektBiblioteki(decimal cena, string opis)
        {
            this.cena = cena;
            this.opis = opis;
        }
    }
}
