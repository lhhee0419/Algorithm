using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(" ");
            List<string> vs = new List<string>();

            foreach (string item in s)
            {
                if (item.Trim() != "")
                    vs.Add(item);
                    
            }

            Console.WriteLine(vs.Count);
        }
    }
}
