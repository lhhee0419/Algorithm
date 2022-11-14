using System;
using System.Collections.Generic;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //{{60, 50}, {30, 70}, {60, 30}, {80, 40}}	4000
            //{{10, 7}, {12, 3}, {8, 15}, {14, 7}, {5, 15}}	120
            //{{14, 4}, {19, 6}, {6, 16}, {18, 7}, {7, 11}}	133
            int[,] sizes = new int[,] { { 60, 50 }, { 30, 70 }, {60, 30}, {80, 40} };

            int answer = 0;

            int max1 = 0;
            int max2 = 0;

            for (int i = 0; i < sizes.Length / 2; i++)
            {
                if(sizes[i,0].CompareTo(sizes[i, 1]) == -1) //왼쪽값 보다 오른쪽 값이 클 경우 위치 변경
                {
                    int x = sizes[i, 0];
                    sizes[i, 0] = sizes[i, 1]; 
                    sizes[i, 1] = x; 
                }

                if (max1.CompareTo(sizes[i, 0]) == -1)
                    max1 = sizes[i, 0];

                if (max2.CompareTo(sizes[i, 1]) == -1)
                    max2 = sizes[i, 1];
            }

            answer = max1 * max2;

            Console.WriteLine(answer);
        }
    }
}
