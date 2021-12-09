using System;

namespace Tagesphase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Benutzer nach Uhrzeit fragen
            Console.WriteLine("Bitte gib eine Uhrzeit [h:mm] an");
            DateTime zeit = Convert.ToDateTime(Console.ReadLine());

            // Stunde aus der Uhrzeit ermitteln
            int stunde = zeit.Hour;      // Hour-Eigenschaft des DateTime herausziehen     

            // Tagesphase ermitteln
            string phase;

            switch (stunde)
            {
                case < 6:
                    phase = "Morgen";
                    break;
                case < 12:
                    phase = "Vormittag";
                    break;
                case < 18:
                    phase = "Nachmittag";
                    break;
                case < 24:
                    phase = "Abend";
                    break;
                default:
                    phase = "unbekannt";
                    break;
            }

            // Tagesphase ausgeben
            Console.WriteLine($"Es ist {phase}.");

        }

        static void MainIf(string[] args)
        {
            // Benutzer nach Uhrzeit fragen
            Console.WriteLine("Bitte gib eine Uhrzeit [h:mm] an");
            DateTime zeit = Convert.ToDateTime(Console.ReadLine());

            // Stunde aus der Uhrzeit ermitteln
            int stunde = zeit.Hour;

            // Tagesphase ermitteln
            string phase;
            if (stunde < 6)
            {
                phase = "Morgen";
            }
            else if (stunde < 12)
            {
                phase = "Vormittag";
            }
            else if (stunde < 18)
            {
                phase = "Nachmittag";
            }
            else
            {
                phase = "Abend";
            }

            // Tagesphase ausgeben
            Console.WriteLine($"Es ist {phase}.");
        }
    }
}
