using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers_K_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{1, 5, 2, 6, 3, 7, 4};
            int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
            int[] answer = new int[commands.GetLength(0)];

            for (int i = 0; i < commands.GetLength(0); i++)
            {
                List<int> sort_list = new List<int>();
                for (int j = commands[i,0]-1; j < commands[i,1]; j++)
                {
                    sort_list.Add(array[j]);
                }
                sort_list.Sort();
                int a = commands[i, 2] - 1;
                answer[i] = sort_list[a];

            }
            foreach(int i in answer)
            {
                Console.Write(i);
            }
            
        }
    }
}
