using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3052
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array_int = new int[10];
            int[] array_remain = new int[10];
            int cnt = 0;
            List<int> list_cnt = new List<int>();

            for(int i = 0; i < 10; i++)
            {
                string str = Console.ReadLine();
                array_int[i] = Convert.ToInt32(str)%42;
            }
            
            for(int i = 0; i < 9; i++)
            {
                for(int j = i + 1; j < 10; j++)
                {
                    if (array_int[i] == 99)
                    {
                        break;
                    }
                    if (array_int[i] == array_int[j])
                    {
                        array_int[j] = 99;
                    }                    
                }
            }
            for(int i = 0; i < 10; i++)
            {
                if(array_int[i] != 99)
                {
                    cnt++;
                }
            }
            
            Console.WriteLine(cnt);            
        }
    }
}
