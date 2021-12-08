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

            int r5 = n % 5;
            int q5 = n / 5;
            int result = -1;

            if (r5 > 0)
            {
                if (r5 % 3 == 0)
                {
                    result = (r5 / 3) + q5;
                }
                else
                {
                    if (n % 3 == 0)
                    {
                        result = n / 3;
                    }

                    if (q5 > 0)
                    {
                        for (int i = q5 - 1; i >= 1; i--)
                        {
                            if ((n - i * 5) % 3 == 0)
                            {
                                result = i + ((n - i * 5) / 3);
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                if (n % 5 == 0)
                {
                    result = n / 5;
                }
                else if (n % 3 == 0)
                {
                    result = n / 3;
                }
            }
            Console.WriteLine(result);
        }
    }
}
