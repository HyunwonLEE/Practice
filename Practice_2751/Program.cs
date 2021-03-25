using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2751
{
    class Program
    {
        static void Main(string[] args)
        {
            int int_N = Convert.ToInt32(Console.ReadLine());
            List<int> int_list = new List<int>();
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < int_N; i++)
            {                
                int_list.Add(int.Parse(Console.ReadLine()));
                
            }
            int_list.Sort();
            foreach (int i in int_list)
            {
                sb.Append(i);
            }
            
            for (int i = 0;i < sb.Length; i++)
            {
                Console.WriteLine(sb[i].ToString());
            }
        }
        
    }
}
