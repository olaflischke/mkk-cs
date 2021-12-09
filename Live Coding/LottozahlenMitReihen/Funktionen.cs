using System;
using System.Collections.Generic;

namespace Lottozahlen
{
    static class Funktionen
    {
        /// <summary>
        /// Erzeugt eine Reihe von 6 Zahlen zwischen 1 und 49, nicht wiederholend.
        /// </summary>
        public static List<int> ErzeugeReihe()
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

            return zahlen;
        }
    }
}