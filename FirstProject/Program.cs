using FirstProject.Aufgaben;
using System;

using System.Linq;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================================================");
            Console.WriteLine("== Ausführung aller Programmier-Aufgaben ==");
            Console.WriteLine("=========================================================================");

      
            // Aufgabe 1: Statistik 
        
            Console.WriteLine("\n--- Aufgabe 1: Statistik   -----------------------------------------------------------------------------------");

            aufgabe_array forarray = new aufgabe_array(10);
            forarray.Anzeigen();








         
            // Aufgabe 2: Lottozahlen
          
            Console.WriteLine("\n--- Aufgabe 2: Lottozahlen ------------------------------------------------------------------------------------");

            Lottozahlen lotto = new Lottozahlen();
            lotto.Ziehung();

         
            // Aufgabe 3: Binärzahlen 
         
            Console.WriteLine("\n--- Aufgabe 3: Binärrechner -- ---------------------------------------------------------------------------------");

            Console.Write("Eingabe Dezimalzahl (0-255): ");

          
            if (int.TryParse(Console.ReadLine(), out int dezimal) && dezimal >= 0 && dezimal <= 255)
            {
                Binaerzahlen rechner = new Binaerzahlen();
                rechner.Umrechnen(dezimal);
            }
            else
            {
                Console.WriteLine(" Muss eine Zahl zwischen 0 und 255 sein");
            }

         
            // Aufgabe 4: Mittelwert
           
            Console.WriteLine("\n--- Aufgabe 4: Mittelwert   - -------------------------------------------------------------------------------------");

            Console.Write("Anzahl Zahlen (mind. 3): ");

            if (int.TryParse(Console.ReadLine(), out int größe) && größe >= 3)
            {
                Mittelwert brechner = new Mittelwert(größe);
                brechner.Berechnen();
            }
            else
            {
                Console.WriteLine(" Muss eine Zahl von mindestens 3 sein");
            }

            Console.WriteLine("\n=========================================================================");
            Console.WriteLine("----------------------------- Programmende ------------------------------");
            Console.WriteLine("=========================================================================");

          
            Console.ReadKey();
        }
    }
}