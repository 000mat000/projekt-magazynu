using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazyn
{
    internal class but
    {
        public string Kod { get; set; }
        public string Firma { get; set; }
        public string Kategoria { get; set; }
        public string Nazwa { get; set; }
        public string Kolor { get; set; }
        public double Cena { get; set; }

        public but(string k, string fir, string kat, string naz, string kol, double cen)
        {
            Kod = k;
            Firma = fir;
            Kategoria = kat;
            Nazwa = naz;
            Kolor = kol;
            Cena = cen;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5}", Kod, Firma, Kategoria, Nazwa, Kolor, Cena);
        }
    }
}
