using System;
using System.Linq; 


namespace FirstProject.Aufgaben
{
    public class Mittelwert
    {
        private int[] zahlen;
        private Random zufall;

       
        public Mittelwert(int größe)
        {
           
            if (größe < 3)
            {
                größe = 3;
                Console.WriteLine("Hinweis: Array-Größe auf Minimum 3 gesetzt.");
            }

            zahlen = new int[größe];
            zufall = new Random();

           
            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = zufall.Next(1, 100); 
           
            }
        }

        public void Berechnen()
        {
           
            Console.WriteLine(string.Join(", ", zahlen));

          
            int min = zahlen.Min();
            int max = zahlen.Max();

            int gesamtSumme = zahlen.Sum();
            int summeOhneExtrem = gesamtSumme - min - max;

          
            double mittelwert = summeOhneExtrem / (double)(zahlen.Length - 2);

        
            Console.WriteLine($"Mittelwert ohne Min und Max: {mittelwert:F3}");
        }
    }
}