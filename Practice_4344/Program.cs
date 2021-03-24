using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_4344
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_N = Console.ReadLine();
            int int_N = Convert.ToInt32(str_N);
            string[] array_str = new string[int_N];
            int[] array_int = new int[int_N];
            string[] result = new string[int_N];
            
            for(int i = 0; i < int_N; i++)
            {
                string str = Console.ReadLine();
                string[] array = str.Split(' ');
                List<int> list_int = new List<int>();
                List<int> list_avg = new List<int>();
                foreach (string temp in array)
                {
                    list_int.Add(Convert.ToInt32(temp));
                }
                for(int j = 1; j < list_int[0]+1; j++)
                {
                    list_avg.Add(list_int[j]);
                }
                for(int z = 1; z < list_int[0]+1; z++)
                {
                    if(list_avg.Average() < list_int[z])
                    {
                        array_int[i]++;
                    }
                }
                double a = array_int[i];
                double b = list_int[0];
                result[i] =  string.Format("{0:0.000}",(a / b) * 100) +"%";
            }

            foreach(string i in result)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
