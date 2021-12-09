using System;
using System.Collections.Generic;

namespace Lottozahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zufallsgenerator initalisieren
            Random generator = new Random();
            // Liste für die Zahlen erzeugen
            List<int> zahlen = new List<int>();

            // 6 Zahlen nicht wiederholend erzeugen
            for (int i = 0; i < 6; i++)
            {
                //  Prüfen, ob Zahl schon auf der Liste ist
                int zufallszahl;
                do
                {
                    zufallszahl = generator.Next(1, 50);
                } while (zahlen.Contains(zufallszahl));

                zahlen.Add(zufallszahl);
            }

            // Liste sortieren
            zahlen.Sort();

            // Liste kommagetrennt ausgeben
            string ausgabe = "";
            // foreach (int zahl in zahlen)
            // {
            for (int i = 0; i < zahlen.Count; i++)
            {
                // if (i < zahlen.Count - 1)
                // {
                //     ausgabe = ausgabe + zahlen[i] + ", ";
                // }
                // else
                // {
                //     ausgabe = ausgabe + zahlen[i];
                // }
                ausgabe = ausgabe + zahlen[i] + (i < zahlen.Count - 1 ? ", " : ""); // Inline-If, geht nur bei genau zwei Möglichkeiten (analog =WENN(Prüfung;Dann;Sonst) in Excel)
            }

            //Console.WriteLine(ausgabe.Substring(0, ausgabe.Length - 2));
            Console.WriteLine(ausgabe);

        }
    }
}
