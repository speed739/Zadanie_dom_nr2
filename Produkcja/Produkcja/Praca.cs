using System;
using System.Collections.Generic;
using System.Text;

namespace Produkcja
{
    class Praca
    {
        public void Drukowanie(Pracownik a)
        {

            uint ilosc_etykiet;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Podanie 0 konczy produkcje\n"); Console.ResetColor();

            do
            {
                Console.Write("Podaj ile etykiet chcesz wydrukovac - ");
                ilosc_etykiet = uint.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Print x{0} ", ilosc_etykiet);

                a.Ilosc_wyprodukowana += ilosc_etykiet;
                Console.Write("Dzis wyprodukowales - {0}\n", a.Ilosc_wyprodukowana); Console.ResetColor();

            } while (ilosc_etykiet != 0);

        }

    }
}
