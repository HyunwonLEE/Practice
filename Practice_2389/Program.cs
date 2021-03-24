using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2389
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_data = Console.ReadLine();
            int input_int = Convert.ToInt32(input_data);
            int result = -1;


            for (int i = 0; i < input_int / 5 + 1; i++)
            {
                if ((input_int - (i * 5)) % 3 == 0)
                {
                    result = i + (input_int - (i * 5)) / 3;
                }
            }

            Console.WriteLine(result);

        }
    }
}
