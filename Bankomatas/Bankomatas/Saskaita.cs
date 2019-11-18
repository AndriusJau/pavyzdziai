using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomatas
{
    class Saskaita
    {
        public double Likutis { get; set; }
        public int SaskNumeris { get; set; }
        public List<Tranzakcija> OperSarasas = new List<Tranzakcija>();
    }
}
