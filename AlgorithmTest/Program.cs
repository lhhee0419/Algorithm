using System;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Recursive(n));
        }

        static int Recursive(int num)
        {
            if (num == 0)
            {
                return 0;
            }

            if (num == 1)
            {
                return 1;
            }

            return Recursive(num - 1) + Recursive(num - 2);
        }
    }
}
