using System;
using System.Collections.Generic;


namespace Produkcja
{
    class Praca
    {
        public void Logowanie(List<Pracownik> Pracownicy)
        {
            int id;
            string password, zgoda;

            Console.Write("Logowanie:\nPodaj Id pracownika - ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Podaj haslo ");
            password = Console.ReadLine();

            if (Pracownicy.Exists(x => x.Id_Pracownika == id && x.Zwroc_haslo() == password))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ZALOGOWANY"); Console.ResetColor();

                Drukowanie(Pracownicy.Find(x => x.Id_Pracownika == id && x.Zwroc_haslo() == password));

                Console.Write("Chcesz pracowac innym pracownikiem y/n? - ");
                zgoda = Console.ReadLine(); Console.WriteLine();

                if (zgoda == "y")
                {
                    Logowanie(Pracownicy);
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Koniec!!!"); Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-------------------------------------------------------"); Console.ResetColor();
                }
            }

            else
            {
                Console.WriteLine("Podano zly Id lub haslo");
                Logowanie(Pracownicy);
            }
        }
        void Drukowanie(Pracownik a)
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

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("WYLOGOWANY\n"); Console.ResetColor();

        }
    }
}

