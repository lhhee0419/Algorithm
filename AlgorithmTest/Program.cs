using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split(" ");

            int a = Convert.ToInt32(inputData[0]);
            int b = Convert.ToInt32(inputData[1]);
            int v = Convert.ToInt32(inputData[2]);

            int result = (v - b) / (a - b);
            int r = (v - b) % (a - b);

            if (r > 0)
            {
                result += 1;
            }

            Console.WriteLine(result);
        }
    }
}
