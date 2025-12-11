using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Aufgaben
{
    public class Binärzahlen
    {


      
            private int[] bits;

            public Binärzahlen()
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
