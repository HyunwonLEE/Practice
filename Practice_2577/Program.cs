using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2577
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array_int = new int[3];
            for(int i = 0; i < 3; i++)
            {
                string str = Console.ReadLine();
                array_int[i] = Convert.ToInt32(str);
            }
            string multi = (array_int[0] * array_int[1] * array_int[2]).ToString();
            int[] result = new int[10];      
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < multi.Length; j++)
                {
                    if(multi[j].ToString().Equals(i.ToString()))
                    {
                        result[i]++;
                    }
                }
            }
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
