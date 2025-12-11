using System;

namespace FirstProject.Aufgaben
{
    public class Binaerzahlen
    {
        
        private int[] bits;

        public Binaerzahlen()
        {
            
            bits = new int[8];
        }

      
        public void Umrechnen(int dezimalzahl)
        {
            
            int zahl = dezimalzahl;

           
            for (int i = 7; i >= 0; i--)
            {
    
                bits[i] = zahl % 2;

            
                zahl /= 2;

     
                if (zahl == 0)
                {
                    break;
                }
            }

       
            Console.Write("Ergebnis Binärzahl: ");

         
            for (int i = 0; i < bits.Length; i++)
            {
                Console.Write(bits[i]);
            }
            Console.WriteLine();
        }
    }
}