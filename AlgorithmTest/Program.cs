using System;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vs = Console.ReadLine().Split(" ");

            double a = Convert.ToDouble(vs[0]);
            double b = Convert.ToDouble(vs[1]);

            Console.WriteLine(a / b);
        }
    }
}
