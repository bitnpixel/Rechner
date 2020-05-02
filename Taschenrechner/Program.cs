using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Begrüßung des Nutzers
            Console.WriteLine("Herlich Willkommen zum Konsolen-Taschenrechner");
            Console.WriteLine();

            //Abfrage der beiden Zahlen
            Console.WriteLine("Bitte gib die erste Zahl ein");
            string eingabeErsteZahl = Console.ReadLine("");
            Console.WriteLine();
            Console.WriteLine("Bitte gib die zweite Zahl ein");
            string eingabeZweiteZahl = Console.ReadLine("");

            //Text in Gleitkommazahl umwandeln
            double ersteZahl = Convert.ToDouble(eingabeErsteZahl);
            double zweiteZahl = Convert.ToDouble(eingabeZweiteZahl);

            //Berechnung Ergebnis
            double summe = ersteZahl + zweiteZahl;
        }
    }
}
