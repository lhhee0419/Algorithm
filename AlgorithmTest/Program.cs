using System;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split(" ");

            int h = Convert.ToInt32(inputData[0]);
            int m = Convert.ToInt32(inputData[1]);

            if( m >= 45)
            {
                m = m - 45;
            }else
            {
                if(h == 0)
                {
                    h = 23;
                   
                }else
                {
                    h = h - 1;
                }
                m = 60 - (45 - m);
            }

            Console.WriteLine(h + " " + m);
        }
    }
}
