using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Aufgaben
{
    public class Lottozahlen
    {
        private bool[] gezogen;
        private Random zufall;

        public Lottozahlen()
        {
            gezogen = new bool[50];
     
            zufall = new Random();
        }

        public void Ziehung()
        {
            int count = 0;
            while (count < 6)
            {
                int zahl = zufall.Next(1, 50);
         
                if (!gezogen[zahl])
                {
                    gezogen[zahl] = true;
                    count++;
                }
            }

        
            Console.Write("Gezogene Zahlen: ");
            for (int i = 1; i < gezogen.Length; i++)
            {
                if (gezogen[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
