using System;
using System.Collections.Generic;


namespace Produkcja
{
    class Program
    {
        static void Main(string[] args)
        {
            System_Logowania praca = new System_Logowania();
            Zapis_odczyt_danych dane = new Zapis_odczyt_danych();

            Pracownik a = new Pracownik(1, "Jan", "Kania", "123");
            Pracownik b = new Pracownik(2, "Gosia", "Duraj", "456");
            Pracownik c = new Pracownik(3, "Bartek", "Furgała", "789");
            List<Pracownik> lista_pracownikow = new List<Pracownik>() { a, b, c };

            praca.Logowanie(lista_pracownikow);
            a.Display(a); b.Display(b); c.Display(c);

            dane.Zapis_do_pliku(lista_pracownikow);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------------------"); Console.ResetColor();

            dane.Odczyt_z_pliku(lista_pracownikow);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------------------"); Console.ResetColor();

        }
    }
}
