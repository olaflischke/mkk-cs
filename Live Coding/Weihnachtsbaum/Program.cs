using System;

namespace Weihnachtsbaum
{
    class Program
    {
        static void MainDoHalberBaum(string[] args)
        {

            Console.WriteLine("Wie hoch soll der Baum sein (Do)?");
            int hoehe = Convert.ToInt32(Console.ReadLine());

            string zeile = "";

            do
            {
                zeile = zeile + "*";
                Console.WriteLine(zeile);
            } while (zeile.Length < hoehe);

        }

        static void MainForHalberBaum(string[] args)
        {
            Console.WriteLine("Wie hoch soll der Baum sein (For)?");
            int hoehe = Convert.ToInt32(Console.ReadLine());

            string zeile = "";

            for (int i = 0; i < hoehe; i++)
            {
                zeile = zeile + "*";
                Console.WriteLine(zeile);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Wie hoch soll der Baum sein?");
            int hoehe = Convert.ToInt32(Console.ReadLine());

            string sterne = "*";

            for (int zeile = 0; zeile < hoehe; zeile++)
            {
                string leerzeichen = "";
                for (int nummerDesLeerzeichens = 0; nummerDesLeerzeichens < hoehe - (zeile + 1); nummerDesLeerzeichens++)
                {
                    leerzeichen = leerzeichen + " ";
                }

                // Johny Wachholz' Version (statt obiger For-Schleife):
                // string leerzeichen = new String(' ', (hoehe - (zeile + 1)));

                Console.WriteLine(leerzeichen + sterne);

                sterne = sterne + "**";

            }
        }
    }
}
