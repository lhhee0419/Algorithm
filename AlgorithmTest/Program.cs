using System;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split(" ");

            int a = Convert.ToInt32(inputData[0]);
            int b = Convert.ToInt32(inputData[1]);

            if(a > b)
            {
                Console.WriteLine(">");
            }else if(a < b)
            {
                Console.WriteLine("<");
            }else if(a == b)
            {
                Console.WriteLine("==");
            }
        }
    }
}
