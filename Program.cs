using koscConsole;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę oczek (1-6): ");
        int oczka = int.Parse(Console.ReadLine());

        Kosc kosc1 = new Kosc(oczka);

        Console.WriteLine("\n--- Pierwsza kość ---");
        Console.WriteLine("Liczba utworzonych instancji: " + Kosc.instance);
        Console.WriteLine("Liczba oczek: " + kosc1.liczbaOczek);
        Console.WriteLine("Liczba oczek słownie: " + kosc1.wynikSlownie());
        Console.WriteLine("Nazwa pliku: " + kosc1.pliki[kosc1.idPliku]);

        Kosc kosc2 = new Kosc();

        Console.WriteLine("\n--- Druga kość ---");
        Console.WriteLine("Liczba utworzonych instancji: " + Kosc.instance);
        Console.WriteLine("Liczba oczek: " + kosc2.liczbaOczek);
        Console.WriteLine("Liczba oczek słownie: " + kosc2.wynikSlownie());
        Console.WriteLine("Nazwa pliku: " + kosc2.pliki[kosc2.idPliku]);
    }
}