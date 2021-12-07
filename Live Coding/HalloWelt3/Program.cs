using System;

namespace HalloWelt3
{
    class Program
    {
        // Haupteinstiegspunkt der Anwendung
        static void Main(string[] args)
        {
            // Benutzer nach seinem Namen fragen
            Console.WriteLine("Wie heißt Du?");
            // Variablentyp Variablenname = Wert;
            string benutzer = Console.ReadLine();

            // string benutzer2;
            // benutzer2=Console.ReadLine();

            // Benutzer mit Name begrüßen
            Console.WriteLine($"Hallo {benutzer}!"); // "Strings are immutable"
        } 
    }
}
