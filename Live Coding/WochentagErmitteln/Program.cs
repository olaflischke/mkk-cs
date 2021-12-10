using System;
using System.Globalization;

namespace WochentagErmitteln
{
    class Program
    {
        static void Main(string[] args)
        {
            // Benutzer nach Datum fragen
            Console.WriteLine("Bitte Datum eingeben");
            DateTime eingabe = Convert.ToDateTime(Console.ReadLine());

            // Wochentag des Datums ermitteln
            // string tag = eingabe.DayOfWeek.ToString();
            // string tag=eingabe.ToString("dddd");
            // Alternativ:
            // string tag = Convert.ToString(eingabe.DayOfWeek);
            var day = eingabe.DayOfWeek;

            CultureInfo ci = new CultureInfo("de-DE");
            string tag = ci.DateTimeFormat.GetDayName(day);

            // Wochentag ausgeben
            //Console.WriteLine("Der " + eingabe + " ist ein " + tag + ".");
            Console.WriteLine($"Der {eingabe} ist ein {tag}.");
            // Datumsformatierung mit ToString o.ä. "dddd, dd.MMMM.yyyy H:mm:ss,fff"
        }
    }
}
