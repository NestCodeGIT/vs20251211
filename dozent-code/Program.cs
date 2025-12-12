namespace dozent_code
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int[] array = new int[10];
            Random rnd = new Random();
           // Random rnd = new Random(1);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100);
                Console.Write(array[i] + " ");








            }
            Console.WriteLine();
            int summe =0 ;
            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                summe += array[i];
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"Summe: {summe}");
            //Console.WriteLine($"Summe...............: {summe,10}");


            Console.WriteLine($"min: {min}");

            Console.WriteLine($"max: {max}");
            double durchschnit = (double)summe/  array.Length;

            Console.WriteLine($"durchschnit: {durchschnit}");

            Console.WriteLine($"durchschnit: {durchschnit:F2}");

            Console.WriteLine($"durchschnit: {Math.Round(durchschnit, 2)}");

            Console.WriteLine("---------------------------------------------------------------------------------------");


            Console.WriteLine($"{"Summe:",-20}{summe,10}");
            Console.WriteLine($"{"Minimum:",-20}{min,10}");
            Console.WriteLine($"{"Maximum:",-20}{max,10}");
            Console.WriteLine($"{"Durchschnitt:",-20}{durchschnit,10:F2}");




        }
    }
}