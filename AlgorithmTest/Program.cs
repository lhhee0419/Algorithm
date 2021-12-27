using System;
using System.Collections.Generic;

namespace AlgorithmTest
{
    class Program
    {

        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int sum = a * b * c;

            string strSum = sum.ToString();

            int[] counts = new int[10];


            foreach (char item in strSum)
            {
                counts[Convert.ToInt32(item)-48]++;
            }

            foreach (int count in counts)
            {
                Console.WriteLine(count);
            }
        }
    }
}
