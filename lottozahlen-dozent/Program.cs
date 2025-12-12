namespace lottozahlen_dozent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] lotto= new bool[50];
            Random rnd= new Random();
            int anzahl = 0;
            while(anzahl < 6)
            {
                int zahl =rnd.Next(1,50);
                if (lotto[zahl] == false)
                {
                    lotto[zahl] = true;
                    anzahl++;
                }

            }

            for (int i = 0; i < lotto.Length; i++)
            {

                if (lotto[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();



        }
    }
}



//int[] lottoZahlen = Enumerable.Range(1, 49)
//                              .OrderBy(x => rnd.Next())
//                              .Take(6)
//                              .ToArray();
