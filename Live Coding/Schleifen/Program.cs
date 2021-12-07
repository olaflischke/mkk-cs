using System;

namespace Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wieviele Durchläufe hättsn gern?");
            int laeufe = Convert.ToInt32(Console.ReadLine()); //

            string meldung;

            for (int i = 0; i < laeufe; i++)
            {
                meldung = "For-Zähler: " + i;
                Console.WriteLine(meldung);
            }

            // Geht nicht, weil i nicht mehr bekannt: Console.WriteLine($"Das waren Deine {i} Durchläufe.");

            string zeichen="";
            int zaehler=0;
            do
            {
                zeichen = zeichen + "a";
                Console.WriteLine("Do: " + zeichen);
                zaehler++;
            } while (zeichen.Length < 10 && zaehler < laeufe ); // Fußgesteuert

           zeichen="";

            while (zeichen.Length < 0) // Kopfgesteuert
            {
                zeichen = zeichen + "a";
                Console.WriteLine("While: " + zeichen);
            }

        }
    }
}
