using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBowl
{
    internal class Donto
    {
        public string SSz { get; set; }
        public string Datum { get; set; }
        public string Gyoztes { get; set; }
        public string Eredmeny { get; set; }
        public string Vesztes { get; set; }
        public string Helyszin { get; set; }
        public string VarosAllam { get; set; }
        public int Nezoszam { get; set; }
        public Donto(string sor)
        {
            string[] s = sor.Split(';');
            SSz = s[0];
            Datum = s[1];
            Gyoztes = s[2];
            Eredmeny = s[3];
            Vesztes = s[4];
            Helyszin = s[5];
            VarosAllam = s[6];
            Nezoszam = int.Parse(s[7]);
        }

    }
}
