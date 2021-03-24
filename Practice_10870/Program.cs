using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_10870
{

    class Program
    {
        static int Recursive(int n)
        {            
            if(n <= 1)
            {
                return n;
            }
            else
            {
                return Recursive(n - 1) + Recursive(n - 2);
            }

            


        }
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int result = Recursive(n);
            Console.WriteLine(result);            
            
        }
    }
}
