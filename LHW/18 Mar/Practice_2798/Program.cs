using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2798
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_N = Console.ReadLine();
            string str_M = Console.ReadLine();

            string[] array_str_N = str_N.Split(' ');
            List<int> list_int_M = new List<int>();
            string[] array_str = str_M.Split(' ');
            foreach(string str in array_str)
            {
                list_int_M.Add(Convert.ToInt32(str));
            }            
            list_int_M.Sort();
            int cnt = Convert.ToInt32(array_str_N[0]);
            int temp = 0;
            int result = 0;

            for (int i = 0; i < cnt -2; i++)
            {
                for(int j = i+1; j < cnt -1; j++)
                {
                    for(int x =j+1;x < cnt; x++)
                    {
                        temp = list_int_M[i] + list_int_M[j] + list_int_M[x];
                        if(temp > Convert.ToInt32(array_str_N[1]))
                        {

                            break;
                        }
                        else
                        {
                            if(result < temp)
                            {
                                result = temp;
                            }                            
                        } 
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
