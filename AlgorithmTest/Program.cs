using System;
using System.Diagnostics;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split(" ");

            int a = Convert.ToInt32(inputData[0]);

            if(a >= 90 && a<= 100)
            {
                Console.WriteLine("A");
            }
            else if (a >= 80 && a <= 89)
            {
                Console.WriteLine("B");
            }
            else if (a >= 70 && a <= 79)
            {
                Console.WriteLine("C");
            }
            else if (a >= 60 && a <= 69)
            {
                Console.WriteLine("D");
            }else
            {
                Console.WriteLine("F");
            }
        }
    }
}
