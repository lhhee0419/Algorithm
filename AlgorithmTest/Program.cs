using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] inputData = Console.ReadLine().Split(" ");

            List<int> numList = new List<int>();

            foreach (string item in inputData)
            {
                numList.Add(Convert.ToInt32(item));
            }
            Console.Write(numList.Min() + " " + numList.Max());
        }
    }
}
