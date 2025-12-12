using System;
using System.Collections.Generic;
using System.Text;

namespace dozent_code
{
    
    internal class ArrayStats
    {
        private int[] array;
        private Random rnd;

        public ArrayStats(int size)
        {
            array = new int[size];
            rnd = new Random();
        }

        public void FillArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100);
            }
        }

        public void PrintArray()
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public int Sum()
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }

        public int Min()
        {
            int min = array[0];
            foreach (int num in array)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        public int Max()
        {
            int max = array[0];
            foreach (int num in array)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        public double Average()
        {
            return (double)Sum() / array.Length;
        }

        public void PrintStatistics()
        {
            int sum = Sum();
            int min = Min();
            int max = Max();
            double avg = Average();

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"{"Summe:",-20}{sum,10}");
            Console.WriteLine($"{"Minimum:",-20}{min,10}");
            Console.WriteLine($"{"Maximum:",-20}{max,10}");
            Console.WriteLine($"{"Durchschnitt:",-20}{avg,10:F2}");
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
