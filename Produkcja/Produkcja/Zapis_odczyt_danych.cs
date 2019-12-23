using System;
using System.Collections.Generic;
using System.IO;


namespace Produkcja
{
    class Zapis_odczyt_danych
    {
        static string folder_path = "c:\\Pracownicy\\";
        static DateTime data = DateTime.Today;

        public void Zapis_do_pliku(List<Pracownik> a)
        {
            Directory.CreateDirectory(folder_path);

            a.ForEach(x => Directory.CreateDirectory(folder_path + x.Id_Pracownika.ToString()));
            a.ForEach(x => x.zapis = new StreamWriter(folder_path + x.Id_Pracownika.ToString() + "\\" + data.ToString("d") + ".txt", true));
            a.ForEach(x =>
            {
                using (x.zapis)
                {
                    x.zapis.WriteLine(x.Ilosc_wyprodukowana);
                }
            });

        }
        public void Odczyt_z_pliku(List<Pracownik> a)
        {
            string linijka;
            int suma;

            a.ForEach(x => x.odczyt = new StreamReader(folder_path + x.Id_Pracownika.ToString() + "\\" + data.ToString("d") + ".txt"));
            a.ForEach(x =>
            {
                suma = 0;
                using (x.odczyt)
                {
                    while ((linijka = x.odczyt.ReadLine()) != null)
                    {
                        suma += int.Parse(linijka);
                    }
                }
                Console.WriteLine("Całkowita produkcja {0} {1} - {2} ", x.Imie, x.Nazwisko, suma);
            });

        }

    }
}
