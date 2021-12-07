using System;
using System.Collections.Generic;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {   
                string[] inputData = Console.ReadLine().Split(" ");

                int a = Convert.ToInt32(inputData[0]);
                int b = Convert.ToInt32(inputData[1]);

                if (a == 0 && b == 0)
                    break;

                Console.WriteLine(a + b);
            }
        }
    }
}
