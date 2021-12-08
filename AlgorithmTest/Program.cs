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
                string input = Console.ReadLine();

                if (input == null || input == "")
                    break;

                string[] inputData = input.Split(" ");

                int a = Convert.ToInt32(inputData[0]);
                int b = Convert.ToInt32(inputData[1]);

                Console.WriteLine(a + b);
            }    
        }
    }
}
