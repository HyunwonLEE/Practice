using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2869
{
    class Program
    {
        static void Main(string[] args)
        {   //시간 초과
            string str_input = Console.ReadLine();
            string[] array_input = str_input.Split(' ');            
            //int climb = 0;

            int int_up = Convert.ToInt32(array_input[0]);
            int int_down = Convert.ToInt32(array_input[1]);
            int int_top = Convert.ToInt32(array_input[2]);

            int temp = (int_top - int_up);
            int result =  temp / (int_up - int_down);
            if(temp % (int_up - int_down) != 0)
            {
                ++result;
            }
            ++result;
            //while (true)
            //{
            //    climb = climb + int_up;
            //    result++;
            //    if (climb >= int_top)
            //    {
            //        break;
            //    }

            //    climb = climb - int_down;
            //}
            Console.WriteLine(result);
        }
    }
}
