using System;

namespace If1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie geht es Dir?");

            // Eingabe in Kleinbuchstaben ohne führende oder nachfolgende Leerzeichen annehmen
            string eingabe = Console.ReadLine().ToLower().Trim();

            // Eingabe prüfen
            // Wenn nicht leer, Leertaste
            if (!String.IsNullOrWhiteSpace(eingabe))
            {
                // dann weiter prüfen
                if (eingabe == "gut")
                {
                    Console.WriteLine("Herzlichen Glückwunsch");
                }
                else if (eingabe == "schlecht")
                {
                    Console.WriteLine("Das wird schon wieder");
                }
                else // wird ausgeführt, wenn die oberen Bedinungen nicht zutreffen
                {
                    Console.WriteLine("Dann mal frohes Schaffen.");
                }
            }
            // sonst beliedigt sein
            else
            {
                Console.WriteLine("Dann halt nicht....");
            }
        }
    }
}
