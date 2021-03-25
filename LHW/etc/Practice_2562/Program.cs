using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2562
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array_int = new int[9];
            int result = 0;            
            int order = 0;
            for(int i = 0; i < 9; i++)
            {
                string str = Console.ReadLine();
                array_int[i] = Convert.ToInt32(str);
            }
            for (int i = 0; i < 8; i++)
            {
                int temp = array_int[i];
                for (int j = i +1; j < 9; j++)
                {

                    if(temp < array_int[j])
                    {                        
                        temp = array_int[j];
                        if(temp > result)
                        {
                            order = j + 1;
                            result = temp;
                        }                        
                    }
                    
                }
                if (result == 0)
                {
                    order = i + 1;
                    result = temp;
                    break;
                }
            }

            Console.WriteLine(result);
            Console.WriteLine(order);
        }
    }
}
