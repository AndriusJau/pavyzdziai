using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomatas
{
    enum Valiuta
    {
        EUR, USD, GBP
    }

    class Tranzakcija
    {
        public Valiuta Valiuta { get; set; }
        public double Suma { get; set; }
        public DateTime Data { get; set; }
        public string Paskirtis { get; set; }
    }
}
