using System;
using System.Collections.Generic;

namespace Lottozahlen
{
   partial class Program
    {
        static void Main(string[] args)
        {
            // Benutzer fragen nach gewünschter Anzahl von Reihen
            Console.WriteLine("Reihen?");
            int anzahlReihen = Convert.ToInt32(Console.ReadLine());

            for (int reihe = 0; reihe < anzahlReihen; reihe++)
            {
                // Lottoreihe erzeugen
                List<int> zahlen = Funktionen.ErzeugeReihe();

                // Liste sortieren
                zahlen.Sort();

                // Liste kommagetrennt ausgeben
                string ausgabe = "";
                // foreach (int zahl in zahlen)
                // {
                for (int i = 0; i < zahlen.Count; i++)
                {
                    ausgabe = ausgabe + zahlen[i] + (i < zahlen.Count - 1 ? ", " : ""); // Inline-If, geht nur bei genau zwei Möglichkeiten (analog =WENN(Prüfung;Dann;Sonst) in Excel)
                }

                Console.WriteLine(ausgabe);
            }
        }


    }
}
