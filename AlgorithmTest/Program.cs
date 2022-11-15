using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //brown yellow  return
            //10  2  [4, 3]
            //8   1  [3, 3]
            //24  24 [8, 6]

            int brown = 10;
            int yellow = 2;

            List<int> answer = new List<int>();
            Dictionary<int, int> lst = new Dictionary<int, int>();

            int sum = brown + yellow;

            for (int i = 1; i <= sum / 2; i++)
            {
                if (i < 3) continue;

                int q = sum / i;

                if (sum % i == 0)
                {
                    if (brown == (i * 2) + ((q - 2) * 2))
                    {
                        if(lst.ContainsValue(i))
                        {
                            lst.Remove(q);
                        }

                        lst.Add(i, q);
                    }
                }
            }

            answer.AddRange(lst.Keys);
            answer.AddRange(lst.Values);

            Console.WriteLine(answer.ToArray());
        }
    }
}
