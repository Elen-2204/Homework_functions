using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_element_function
{
   
    class Program
    {
        public static int MaximumEl(List<int> list)
        {
            int max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 5, 7, 11, 5,78, 4, 10 };
            int max = MaximumEl(list);
            Console.WriteLine("Maximum Element: " + max);
        }
    }
}
