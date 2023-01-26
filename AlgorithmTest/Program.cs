using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string today = "2022.05.19";
            string[] terms = new string[] { "A 6", "B 12", "C 3" };
            string[] privacies = new string[] { "2021.05.02 A"
                                              , "2021.07.01 B"
                                              , "2022.02.19 C"
                                              , "2022.02.20 C"};

            List<int> answer = new List<int>();

            DateTime Dttoday = Convert.ToDateTime(today);

            Dictionary<string, int> dicterms = new Dictionary<string, int>();

            foreach (string item in terms)
            {
                string[] a = item.Split(' ');

                dicterms.Add(a[0], Convert.ToInt32(a[1]));
            }

            int seq = 1;

            foreach (string item in privacies)
            {
                string[] a = item.Split(' ');

                DateTime b = Convert.ToDateTime(a[0]);

                if(b.AddMonths(dicterms[a[1]]).AddDays(-1).CompareTo(Dttoday) < 0)
                {
                    answer.Add(seq);
                }

                seq++;
            }

      
            Console.WriteLine(answer.ToArray());
        }
    }
}
