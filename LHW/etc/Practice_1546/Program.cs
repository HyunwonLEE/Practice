using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1546
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_N = Console.ReadLine();
            int int_N = Convert.ToInt32(str_N);
            string[] str = Console.ReadLine().Split(' ');
            int[] array_int = new int[int_N];
            for (int i = 0; i < str.Length; i++)
            {
                array_int[i] = Convert.ToInt32(str[i]);
            }
            int temp = array_int[0];
            int max_sq = 0;
            for (int i = 0; i < int_N; i++)
            {
                if (temp < array_int[i])
                {
                    temp = array_int[i];
                    max_sq = i;
                }
            }
            double result = 0;
            for (int i = 0; i < int_N; i++)
            {
                    result = result + (((double)array_int[i] / temp) * 100);
            }
            Console.WriteLine((double)(result / int_N));

        }
    }
}
