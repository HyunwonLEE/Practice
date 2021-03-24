using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01_10818_min_max
{
    class Program
    {
        static void Main(string[] args)
        {
            //시간 초과
            int input_N = Convert.ToInt32(Console.ReadLine());
            string input_str = Console.ReadLine();
            int[] int_array = new int[input_N];
            string[] char_array = input_str.Split(' ');
            List<int> int_list = new List<int>();
            int max = Convert.ToInt32(char_array[0]);
            int min = Convert.ToInt32(char_array[0]);


            //for (int i = 0; i < input_N -1; i++)
            //{
            //    for(int j = 1; j<input_N; j++)
            //    {
            //        if(Convert.ToInt32(char_array[i]) < Convert.ToInt32(char_array[j]))
            //        {
            //            max = Convert.ToInt32(char_array[j]);
            //        }
            //        if (Convert.ToInt32(char_array[i]) > Convert.ToInt32(char_array[j]))
            //        {
            //            min = Convert.ToInt32(char_array[j]);
            //        }
            //    }
            //}

            foreach(string a in char_array)
            {
                int_list.Add(Convert.ToInt32(a));
            }
            Console.WriteLine(int_list.Min());
            Console.WriteLine(int_list.Max());          
        }
    }
}
