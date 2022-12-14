using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiSignala
{
    internal class Kupec
    {
        protected string ime;
        protected decimal stanje;

        public string Ime { get => ime; set => ime = value; }
        public decimal Stanje { get => stanje; }

        public void BeležiPlačilo(decimal plačilo)
        {
            stanje -= plačilo;
        }
        public void BeležiKlic (int min, TipKlica tip)
        {
            switch (tip)
            {
                case TipKlica.Stacionarno:
                    stanje += min * 0.12m;
                    break;
                case TipKlica.Mobilno: 
                    stanje += min * 0.03m;
                    break;
                default:
                    break;
            }
        }
    }
}
