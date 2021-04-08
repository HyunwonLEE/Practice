using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_11729
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();

        static void Hanoi(int int_N, int from, int to, int x)
        {
            if (int_N <= 1)
            {
                sb.Append("\n" + from + " " + to);
                return;
            }

            Hanoi(int_N - 1, from, x, to);
            sb.Append("\n" + from + " " + to);
            Hanoi(int_N - 1, x, to, from);

        }

        static void Main(string[] args)
        {
            int int_N = Convert.ToInt32(Console.ReadLine());
            Hanoi(int_N, 1, 3, 2);
            Console.Write(Math.Pow(2, 3) - 1);
            Console.WriteLine(sb);
        }
    }
}

