using System;

namespace Fahrenheitrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            char typ;
            do
            {
                // Benutzer nach Temperaturtyp fragen
                Console.WriteLine("\n\r[C]elsius oder [F]ahrenheit?");
                // string typ = Console.ReadLine().ToLower();

                ConsoleKeyInfo taste = Console.ReadKey();
                typ = taste.KeyChar;
            } while (typ != 'c' && typ != 'f');

            // Benutzer nach Temperatur fragen
            Console.WriteLine(Environment.NewLine + "Bitte gib die Temperatur ein:");
            double temperatur = Convert.ToDouble(Console.ReadLine());

            double ergebnis;
            if (typ == 'c')
            {
                // Celsius in Fahrenheit
                ergebnis = temperatur * 1.8 + 32;
            }
            else
            {
                // Fahrenheit in Celsius
                ergebnis = (temperatur - 32) / 1.8;
            }

            Console.WriteLine( Math.Round(ergebnis, 2));
        }

        static void MainFzuC(string[] args)
        {
            // Benutzer nach Temperatur in Fahrenheit fragen
            Console.WriteLine("Bitte gib die Temperatur in Fahrenheit ein:");
            // string eingabe = Console.ReadLine(); // "110"
            // double fahrenheit = Convert.ToDouble(eingabe);
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            // Temperatur umrechnen
            double celsius = (fahrenheit - 32) / 1.8;

            // Temperatur ausgeben (110 °F in °C: 43,3333)
            Console.WriteLine(fahrenheit + " °F in °C: " + celsius);
        }
    }
}
