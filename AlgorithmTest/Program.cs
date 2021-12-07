using System;
using System.Collections.Generic;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int newNum = input;

            int n = 0, n1 = 0, n10 = 0, count = 0;

            while (true)
            {
                if (input == newNum && count != 0)
                    break;

                if (newNum >= 10)
                { 
                    n10 = newNum / 10;
                }
                else
                {
                    n10 = 0;
                }

                n1 = newNum % 10;
                n = (n1 + n10) % 10;

                newNum = Convert.ToInt32(n1.ToString() + n.ToString());
                count++;
            }
            Console.WriteLine(count.ToString());
        }
    }
}
