using System;

namespace Zahlenraten
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comupter "denkt" sich eine Zahl
            Random zufallsGenerator = new Random();
            int computerZahl = zufallsGenerator.Next(1, 11);

            Console.WriteLine(computerZahl);

            // Benutzer rät 3mal
            int benutzerZahl;
            int versuche = 1;
            do
            {
                // Zahl des Benutzers gleich Computerzahl?
                Console.WriteLine("Bitte rate eine Zahl (Versuch Nr. " + versuche + ")");
                benutzerZahl = Convert.ToInt32(Console.ReadLine());
                // Wenn nein, nochmal raten (mx. 3mal)
                versuche++;
            } while (benutzerZahl != computerZahl && versuche <= 3);

            // Wenn ja, Hurra!
            if (benutzerZahl == computerZahl)
            {
                Console.WriteLine("Prima!");
            }
            // Immer: "Dir richtige Zahl war...."
            Console.WriteLine("Die richtige Zahl war " + computerZahl);

            Console.WriteLine("Press any key to exit.");
            ConsoleKeyInfo key= Console.ReadKey();
        }
    }
}
