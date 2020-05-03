using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechner
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
            string eingabeErsteZahl = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Bitte gib die zweite Zahl ein");
            string eingabeZweiteZahl = Console.ReadLine();

            //Text in Gleitkommazahl umwandeln
            double ersteZahl = Convert.ToDouble(eingabeErsteZahl);
            double zweiteZahl = Convert.ToDouble(eingabeZweiteZahl);

            //Berechnung Ergebnis
            double summe = Addition(ersteZahl,zweiteZahl);

            //Ausgabe des Ergebnisses
            Console.WriteLine("Das Ergebnis lautet: {0}", summe);
            WartenAufBenutzerEingabe();
        }

        static void WartenAufBenutzerEingabe()
        {
            Console.WriteLine("Bitte drücke die Enter-Taste zum beenden...");
            Console.ReadLine();
        }

        static double Addition (double summand1, double summand2)
        {
            double ergebnis = summand1 + summand2;

            return ergebnis;
        }
    }
}
