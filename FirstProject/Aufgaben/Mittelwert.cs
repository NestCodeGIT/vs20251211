using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Aufgaben
{
    public class Mittelwert
    {


        private int[] zahlen;
        private Random zufall;

        public Mittelwert(int größe)
        {
            zahlen = new int[größe];
            zufall = new Random();

            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = zufall.Next(1, 100); 
             
            }
        }

        public void Berechnen()
        {
            Console.WriteLine("Zahlen: " + string.Join(", ", zahlen));

            int min = zahlen.Min();
            int max = zahlen.Max();

            int summe = zahlen.Sum() - min - max;
            double mittelwert = summe / (double)(zahlen.Length - 2);

            Console.WriteLine($"Mittelwert ohne Min und Max: {mittelwert:F3}");
        }
    }
}
