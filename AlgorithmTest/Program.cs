using System;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split(" ");

            int n = Convert.ToInt32(inputData[0]);
            int x = Convert.ToInt32(inputData[1]);

            string[] array = Console.ReadLine().Split(" ");

            for (int i = 0; i < array.Length; i++)
            {
                int value = Convert.ToInt32(array[i]);

                if(value < x)
                {
                    Console.Write(value + " ");
                }
            }
        }
    }
}
