using System;
using System.Globalization;
using System.IO;
using System.Linq; // "L"anguage "In"tegrated "Q"uery - Mengenoperationen

namespace Waehrungsrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays bauen
            string[] zeichen = null;
            string[] kurse = null;

            // CSV einlesen
            string csvDatei = @"C:\tmp\Mobil KK CS GL\repo\mkk-cs\Live Coding\CSV\eurofxref.csv";

            // Es könnte sein, dass die Datei fehlt...
            if (!File.Exists(csvDatei))
            {
                Console.WriteLine("Datei nicht gefunden. Taste zum Beenden.");
                Console.ReadKey();
                return;
            }

            try // Versuch mal...
            {
                using (StreamReader reader = new StreamReader(csvDatei)) // StreamReader liest einen Stream (Datei) ein (Forward only)
                {
                    // CSV Datei hat 2 Zeilen - immer.

                    // Zeile 1
                    string zeile1 = reader.ReadLine();
                    string[] daten = zeile1.Split(", ");
                    zeichen = TrimArray(daten);

                    // Zeile 2
                    string zeile2 = reader.ReadLine();
                    daten = zeile2.Split(", ");
                    kurse = TrimArray(daten);
                }
            }
            catch (Exception ex) // ...wenns schiefgeht, tu dies hier:
            {
                Console.WriteLine($"Fehler beim Dateizugriff: {ex.Message}");
                Console.ReadKey();
                return; // Programm beenden
            }

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
                NumberFormatInfo nfi = new NumberFormatInfo() { NumberDecimalSeparator = "." }; // EZB verwendet "." als Dezimaltrennzeichen

                double ergebnis = betrag / Convert.ToDouble(kurse[index], nfi);
                // Ergebnis ausgeben
                //Console.WriteLine("EUR: " + Math.Round(ergebnis, 4));
                Console.WriteLine($"EUR: {ergebnis:0.00}");
            }
            else
            {
                Console.WriteLine("Unbekannte Währung!");
            }
        }


        static void MainAufgabe(string[] args)
        {
            // Arrays bauen
            string[] zeichen = null;
            string[] kurse = null;

            // CSV einlesen
            string csvDatei = @"C:\tmp\Mobil KK CS GL\repo\mkk-cs\Live Coding\CSV\eurofxref.csv";

            using (StreamReader reader = new StreamReader(csvDatei)) // StreamReader liest einen Stream (Datei) ein (Forward only)
            {
                int zeilenNr = 1;
                while (!reader.EndOfStream)
                {
                    string zeilenDaten = reader.ReadLine(); // Reader liest eine Zeile (verschiebt danach einen gedachten Cursor in die nächste Zeile - "Forward only")
                    // Date, USD, JPY, BGN, CZK, DKK, GBP, HUF, PLN, RON, SEK, CHF, ISK, NOK, HRK, RUB, TRY, AUD, BRL, CAD, CNY, HKD, IDR, ILS, INR, KRW, MXN, MYR, NZD, PHP, SGD, THB, ZAR, 

                    string[] daten = zeilenDaten.Split(", ");
                    // 0: Date
                    // 1: USD
                    // 2: JPY
                    // ....


                    //  1. Zeile -> Waehrungszeichen
                    if (zeilenNr == 1)
                    {
                        zeichen = TrimArray(daten);
                        // zeichen = new string[daten.Count() - 1];
                        // for (int i = 0; i < daten.Length - 1; i++)
                        // {
                        //     zeichen[i] = daten[i + 1];
                        // }
                    }
                    else if (zeilenNr == 2)
                    {
                        kurse = TrimArray(daten);
                        // kurse = new string[daten.Length - 1];
                        // for (int i = 0; i < daten.Length; i++)
                        // {
                        //     kurse[i] = daten[i + 1];
                        // }
                    }

                    zeilenNr++;
                }
            }


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
                NumberFormatInfo nfi = new NumberFormatInfo() { NumberDecimalSeparator = "." }; // EZB verwendet "." als Dezimaltrennzeichen

                double ergebnis = betrag / Convert.ToDouble(kurse[index], nfi);
                // Ergebnis ausgeben
                //Console.WriteLine("EUR: " + Math.Round(ergebnis, 4));
                Console.WriteLine($"EUR: {ergebnis:0.00}");
            }
            else
            {
                Console.WriteLine("Unbekannte Währung!");
            }
        }

        /// <summary>
        /// Nimmt aus dem gg. Stringarray alle Strings außer dem ersten, und gibt sie als neues Stringarray zurück.
        /// </summary>
        static string[] TrimArray(string[] daten)
        {
            string[] ergebnisse = new string[daten.Length - 1];

            for (int i = 0; i < daten.Length - 1; i++)
            {
                ergebnisse[i] = daten[i + 1];
            }

            return ergebnisse;
        }
    }
}
