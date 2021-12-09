using System;
using System.Collections.Generic;

namespace WaehrungsrechnerDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary (Wörterbuch, Telefonbuch) erzeugen
            Dictionary<string, double> sorten = new Dictionary<string, double>();

            // Dictionary mit Keys und Werten füllen
            sorten.Add("USD", 1.1256);
            sorten.Add("JPY", 127.83);
            sorten.Add("ZAR", 17.9612);
            sorten.Add("VND", 25892.90);

            // Benutzer nach Währung fragen
            Console.WriteLine("Welche Währung?");
            string waehrung = Console.ReadLine().ToUpper().Trim();

            // Benutzer nach Fremdbetrag fragen
            Console.WriteLine($"Bitte gib einen Betrag in {waehrung} ein:");
            double betrag = Convert.ToDouble(Console.ReadLine());

            // In Euro umrechnen

            // Gewünschte Währung im Dictionary vorhanden?
            if (sorten.ContainsKey(waehrung)==true)
            {
                double ergebnis = betrag / sorten[waehrung]; // Dictionary-Value abfragen mit dictionary[key]
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
