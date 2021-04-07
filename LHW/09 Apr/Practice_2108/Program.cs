using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2108
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] count_sort = new int[8001];
            int int_N = Convert.ToInt32(Console.ReadLine());
            int mid = 0;
            int max = 0;
            int min = 0;
            int range = 0;
            double avg = 0f;
            int max_cnt = 0;
            int cnt = 0;
            ArrayList arraylist = new ArrayList();
            for (int i = 0; i < int_N; i++)
            {
                int str = Convert.ToInt32(Console.ReadLine());

                count_sort[str + 4000]++;                

                if (max < str || i == 0) max = str;
                if (min > str|| i == 0) min = str;

                avg = avg + str;
            }
            
            for (int i = 0; i < count_sort.Length; i++)
            {

                if (count_sort[i] > 0)
                {
                    for(int j = 0; j < count_sort[i]; j++)
                    {
                        arraylist.Add(i);
                    }
                    

                    if (cnt < count_sort[i])
                    {
                        max_cnt = i;
                        cnt = count_sort[i];                       
                        
                    }
                }

            }
            ArrayList cnt_array = new ArrayList();
            for(int i = 0; i < count_sort.Length; i++)
            {
                if(count_sort[i] == cnt)
                {
                    cnt_array.Add(i);
                }
            }            
            
            avg = avg / int_N;
            Console.WriteLine(Math.Round(avg, 0));

            mid = int.Parse(arraylist[arraylist.Count > 1 ? arraylist.Count / 2 : 0].ToString());
            mid = mid - 4000;
            Console.WriteLine(mid);

            max_cnt = cnt_array.Count == 1 ? max_cnt : int.Parse(cnt_array[1].ToString());
            max_cnt = max_cnt - 4000;
            Console.WriteLine(max_cnt);

            range = max - min;
            Console.WriteLine(range);

        }

    }
}
