using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_23_Grupe
{
    internal class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Oib { get; set; }

        public override string ToString()
        {
            return $"Učenik: - {Oib}";
        }

        public Ucenik(string ime, string prezime, int oib)
        {
            Ime = ime;
            Prezime = prezime;
            Oib = oib;
        }
    }
}
