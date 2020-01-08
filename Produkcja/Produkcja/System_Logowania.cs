using System;
using System.Collections.Generic;
using System.Linq;

namespace Produkcja
{
    class System_Logowania : Praca
    {
        public void Logowanie(List<Pracownik> Pracownicy)
        {
            int id;
            string password, zgoda;
            Pracownik pomocniczy; //zmienna przechowuje obiekt zwracano przez funkcje FirstorDefault
            
            Console.Write("Logowanie:\nPodaj Id pracownika - ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Podaj haslo ");
            password = Console.ReadLine();

            pomocniczy = Pracownicy.FirstOrDefault(
                (x => x.Id_Pracownika == id && x.Zwroc_haslo(password) == true));
            
            if (pomocniczy != null)
            {

                Drukowanie(pomocniczy);
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

