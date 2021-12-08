using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Dictionary<char, int> dicCount = new Dictionary<char, int>();
            
            for (int i =65; i <= 90; i++)
            {
                dicCount.Add(Convert.ToChar(i), 0);
            }
            
            foreach (char item in s.ToUpper())
            {
                if(dicCount.ContainsKey(item))
                {
                    dicCount[item] += 1;
                }
            }
            int max = dicCount.Values.Max();
            char result = dicCount.FirstOrDefault( x => x.Value == max).Key;

            dicCount.Remove(result);

            if (dicCount.Values.Max() == max)
                result = '?';

            Console.WriteLine(result);
        }
    }
}
