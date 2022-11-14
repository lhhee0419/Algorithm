using System;
using System.Collections.Generic;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 4;  //사과의 최고점
            int m = 3;  //사과 포장 갯수
            int[] score = new int[] { 4, 1, 2, 2, 4, 4, 4, 4, 1, 2, 4, 2 }; //사과점수
            
            int answer = 0;

            Array.Sort(score);
            Array.Reverse(score);

            int length = score.Length;
            int boxQty = length / m;

            for (int i = 1; i <= boxQty; i++)
            {
                answer += score[(i * m) - 1] * m;
            }

            Console.WriteLine(answer);
        }
    }
}
