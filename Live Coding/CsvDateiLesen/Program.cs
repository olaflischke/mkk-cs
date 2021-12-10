using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CsvDateiLesen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> spieler = new Dictionary<string, string>();
            List<Spieler> spielerListe = new List<Spieler>();

            string csvDatei = @"C:\tmp\Mobil KK CS GL\Live Coding\CSV\Weltmeister2014.csv";

            using (StreamReader reader = new StreamReader(csvDatei) )//StreamReader(csvDatei))
            {
                int zeilenNr = 1;
                while (!reader.EndOfStream)
                {
                    string zeile = reader.ReadLine(); // Reader liest eine Zeile als String
                    if (zeilenNr > 1) // Erste Zeile enthält Überschriften
                    {
                        // Verarbeitung von CSV
                        string[] daten = zeile.Split(';');
                        //List<string> liste=daten.ToList();
                        // spieler.Add(daten[0], daten[6]);
                        Spieler spieler = new Spieler() { Name = daten[0], Funktion = daten[6], WindowsLogin = daten[2] };
                        // spieler.Name = daten[0];
                        // spieler.Funktion = daten[6];
                        // spieler.WindowsLogin = daten[2];
                        spielerListe.Add(spieler);
                    }

                    zeilenNr++;
                }
            } // Streamreader wird disposed (Datei geschlossen)

            // Liste ausgeben
            foreach (Spieler item in spielerListe)
            {
                Console.WriteLine($"{item.Name}: {item.Funktion} ({item.WindowsLogin})");
            }

        }
    }

    class Spieler
    {
        public string Name { get; set; }
        public string Funktion { get; set; }
        public string WindowsLogin { get; set; }
    }
}
