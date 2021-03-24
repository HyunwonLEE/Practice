using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_8958
{
    class Program
    {
        static void Main(string[] args)
        {
            int int_N = Convert.ToInt32(Console.ReadLine());
            string[] array_input = new string[int_N];
            int[] array_result = new int[int_N];
            for (int i = 0; i < int_N; i++)
            {
                string str = Console.ReadLine();
                array_input[i] = str;
                
            }
            for(int i = 0; i < array_input.Length; i++)
            {
                string str = array_input[i];
                int point = 0;
                for(int j = 0; j < array_input[i].Length; j++)
                {
                    if(str[j].Equals('O'))
                    {
                        point++;
                    }
                    else
                    {
                        point = 0;
                    }
                    array_result[i] = array_result[i] + point;
                }
            }
            
            foreach (int i in array_result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
