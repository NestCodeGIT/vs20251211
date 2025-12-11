using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Aufgaben
{
    internal class aufgabe_array
    {

      
            private int[] zahlen;

            private Random zufall;

            public aufgabe_array(int size)
            {
                zufall = new Random();
                zahlen = new int[size];
                for (int i = 0; i < zahlen.Length; i++)
                {
                    zahlen[i] = zufall.Next(1, 100);
                }
            }

            public void Anzeigen()
            {
                Console.WriteLine("Zahlen: " + string.Join(", ", zahlen));
                int summe = zahlen.Sum();

                int min = zahlen.Min();

                int max = zahlen.Max();
                double durchschnitt = summe / (double)zahlen.Length;
                Console.WriteLine($"Minimum: {min}");

                Console.WriteLine($"Maximum: {max}");


                Console.WriteLine($"Summe: {summe}");
                Console.WriteLine($"Durchschnitt: {durchschnitt:F1}");
            }
        }

        



    
}
