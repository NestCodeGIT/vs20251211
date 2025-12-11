using FirstProject.Aufgaben;
using System;
using System.Linq;

namespace FirstProject
{
    internal class Program
    {
    

            static void Main(string[] args)
            {

            Console.WriteLine("-------------------------------------------------------------------------Aufgabe 1 : Statistik");

            aufgabe_array forarray = new aufgabe_array(10);
            forarray.Anzeigen();



            Console.WriteLine("-------------------------------------------------------------------------Aufgabe 2 : Lottozahlen");

            Lottozahlen lotto = new Lottozahlen();
            lotto.Ziehung();


            Console.WriteLine("-------------------------------------------------------------------------Aufgabe 3 : BinärRechner");



            Console.Write("Eingabe Dezimalzahl (0-255): ");
            int dezimal = int.Parse(Console.ReadLine());

            Binärzahlen rechner = new Binärzahlen();
            rechner.Umrechnen(dezimal);




            Console.WriteLine("-------------------------------------------------------------------------Aufgabe 4 : Mittelwert");



            Console.Write("Anzahl Zahlen: ");
            int größe = int.Parse(Console.ReadLine());

            Mittelwert brechner = new Mittelwert(größe);
            brechner.Berechnen();
           


        }
        
    }
}
