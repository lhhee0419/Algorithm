using System;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split(" ");

            int year = Convert.ToInt32(inputData[0]);

            if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("1");
            }else
            {
                Console.WriteLine("0");
            }
        }
    }
}
