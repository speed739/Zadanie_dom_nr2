using System;
using System.Collections.Generic;


namespace Produkcja
{
    class System_Logowania : Praca
    {
        public void Logowanie(List<Pracownik> Pracownicy)
        {
            int id;
            string password, zgoda;

            Console.Write("Logowanie:\nPodaj Id pracownika - ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Podaj haslo ");
            password = Console.ReadLine();

            if (Pracownicy.Exists(x => x.Id_Pracownika == id && x.Zwroc_haslo(password) == true))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ZALOGOWANY"); Console.ResetColor();

                Drukowanie(Pracownicy.Find(x => x.Id_Pracownika == id && x.Zwroc_haslo(password) == true));

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

    }
}

