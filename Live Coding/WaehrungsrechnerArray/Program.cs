using System;

namespace Waehrungsrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays bauen
            string[] zeichen = new string[] { "USD", "JPY", "DKK", "SEK", "ZAR" };
            double[] kurse = new double[] { 1.1256, 127.83, 7.4363, 10.2573, 17.9612 };

            // Benutzer nach Währung fragen
            Console.WriteLine("Welche Währung?");
            string waehrung = Console.ReadLine().ToUpper();

            // Benutzer nach Fremdbetrag fragen
            Console.WriteLine($"Bitte gib einen Betrag in {waehrung} ein:");
            double betrag = Convert.ToDouble(Console.ReadLine());

            // In Euro umrechnen
            int index = Array.IndexOf(zeichen, waehrung); // Wenn nix gefunden: -1
            if (index >= 0)
            {
                double ergebnis = betrag / kurse[index];
                // Ergebnis ausgeben
                //Console.WriteLine("EUR: " + Math.Round(ergebnis, 4));
                Console.WriteLine($"EUR: {ergebnis:0.00}");
            }
            else
            {
                Console.WriteLine("Unbekannte Währung!");
            }
        }
    }
}
