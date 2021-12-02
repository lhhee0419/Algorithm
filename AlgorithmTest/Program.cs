using System;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vs = Console.ReadLine().Split(" ");

            int A = Convert.ToInt32(vs[0]);
            int B = Convert.ToInt32(vs[1]);
            int C = Convert.ToInt32(vs[2]);

            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A * B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);

        }
    }
}
