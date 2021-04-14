using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_11650
{
    class Program
    {
        static void Main(string[] args)
        {
            int int_N = Convert.ToInt32(Console.ReadLine());
            string[] array_str = new string[int_N];
            int[] sort = new int[int_N];
            int[,] a = new int[int_N, 2];

            for (int i = 0; i < int_N; i++)
            {
                array_str[i] = Console.ReadLine();
                string[] str = array_str[i].Split(' ');

                for (int j = 0; j < str.Length; j++)
                {
                    a[i, j] = int.Parse(str[j]);
                    //a[i] += Math.Abs(int.Parse(str[j]));
                }
                sort[i] = i;                
                for (int j = 0; j <= i; j++)
                {
                    int x = a[i, 0];
                    int y = a[i, 1];
                    int c = sort[i];
                    if (a[i,0] <  a[j,0])
                    {

                        a[i,0] = a[j,0];
                        a[i, 1] = a[j, 1];
                        a[j,0] = x;
                        a[j, 1] = y;
                        sort[i] = sort[j];
                        sort[j] = c;                       

                    }
                    else if(a[i,0] == a[j,0] && a[i, 1] < a[j, 1])
                    {
                        a[i, 0] = a[j, 0];
                        a[i, 1] = a[j, 1];
                        a[j, 0] = x;
                        a[j, 1] = y;
                        sort[i] = sort[j];
                        sort[j] = c;
                    }

                }

            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < sort.Length; i++)
            {
                sb.Append(array_str[sort[i]] + "\n");
            }

            Console.WriteLine(sb);



        }
    }
}
