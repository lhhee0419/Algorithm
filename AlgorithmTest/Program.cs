using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = Convert.ToInt32(Console.ReadLine());

            List<double> overAverage = new List<double>();
            
            for (int i = 0; i < inputCount; i++)
            {
                string[] inputData = Console.ReadLine().Split(" ");
                List<int> scorelist = new List<int>();

                foreach (string item in inputData)
                {   
                    scorelist.Add(Convert.ToInt32(item));
                }

                double repeatCount = scorelist[0];

                scorelist.RemoveAt(0);

                double average = scorelist.Average();
                double count = 0;

                foreach (int score in scorelist)
                {
                    if(score > average)
                    {
                        count++;
                    }
                }

                double percent = count / repeatCount * 100;
                overAverage.Add(percent);
            }

            foreach (double percent in overAverage)
            {
                Console.WriteLine(String.Format("{0:0.000}", percent) + "%");
            }
        }
    }
}
