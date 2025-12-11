using System;
using System.Linq;

using System.Collections.Generic;
using System.Text;

namespace FirstProject.Aufgaben
{

  
    public class aufgabe_array
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
       
            Console.WriteLine(string.Join(", ", zahlen));

         
            int summe = zahlen.Sum();
            int min = zahlen.Min();
            int max = zahlen.Max();

           
            double durchschnitt = summe / (double)zahlen.Length;

            
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Durchschnitt: {durchschnitt:F1}"); 
           
            Console.WriteLine($"Summe: {summe}");
        }
    }
}