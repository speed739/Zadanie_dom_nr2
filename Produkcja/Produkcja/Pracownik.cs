using System;
using System.IO;

namespace Produkcja
{
    class Pracownik
    {
        public string Imie, Nazwisko;
        public int Id_Pracownika;
        string haslo;

        public uint Ilosc_wyprodukowana = 0;
        const int target = 100;
        public StreamWriter zapis;
        public StreamReader odczyt;

        public Pracownik(int idPracovnika, string imie, string nazvisko, string haslo)
        {
            Id_Pracownika = idPracovnika;
            Imie = imie;
            Nazwisko = nazvisko;
            this.haslo = haslo;
        }
        public bool Zwroc_haslo(string password)
        {
            if (password == haslo)
            {
                return true;
            }
            return false;
        }

        public void Display(Pracownik a)
        {
            Console.Write("Ilosc wyprodukovana przez - {0} {1} = ", a.Imie, a.Nazwisko);

            if (a.Ilosc_wyprodukowana < (target / 3))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(a.Ilosc_wyprodukowana); Console.ResetColor();

            }

            if (a.Ilosc_wyprodukowana >= (target / 3) && a.Ilosc_wyprodukowana < (target / 1.5))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(a.Ilosc_wyprodukowana); Console.ResetColor();

            }

            if (a.Ilosc_wyprodukowana > (target / 1.5))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(a.Ilosc_wyprodukowana); Console.ResetColor();

            }
            Console.WriteLine();
        }
    }
}

