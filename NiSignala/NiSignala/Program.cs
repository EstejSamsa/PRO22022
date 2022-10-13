using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiSignala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kupec janez = new Kupec();
            janez.Ime = "Janez Novak";
            janez.BeležiKlic(10, TipKlica.Stacionarno);
            Console.WriteLine(janez.Ime + " dolguje " + janez.Stanje);
            Console.WriteLine("Get Type" + janez.GetType());
            Console.WriteLine("to String" + janez.ToString());
            Kupec alenka = new Kupec60();
            alenka.Ime = "Alenka Novak";
            alenka.BeležiKlic(100, TipKlica.Mobilno);
            Console.WriteLine(alenka.Ime + " dolguje " + alenka.Stanje);
            Console.ReadLine();
        }
    }
}
