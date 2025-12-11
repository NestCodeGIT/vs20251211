using System;
using System.Collections.Generic; 

using System.Linq; 


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
                
            List<int> gezogeneZahlen = new List<int>();

      
            while (count < 6)
           
            {
               
                int zahl = zufall.Next(1, 50);

                if (!gezogen[zahl])
                   
                {
                    gezogen[zahl] = true; 
               
                    gezogeneZahlen.Add(zahl);
                 
                    count++;
                  
                }
            }

           
            gezogeneZahlen.Sort();

            Console.Write("Gezogene Zahlen (sortiert): ");

        
            Console.WriteLine(string.Join(" ", gezogeneZahlen));
        }
    }
}