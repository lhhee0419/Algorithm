using System;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Recursive(a));
        }

        static int Recursive(int num)
        {
            if(num == 0 || num ==1)
            {
                return 1;
            }
            
            return num * Recursive(num-1);
        }
    }
}
