using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            AddArray aarr = new AddArray();
            int[] arr_int = aarr.AddArray2("AA100.txt");

            QuickSort qs = new QuickSort();
            qs.MetodQuickSort(ref arr_int, 0, 99);

            for (int i = 0; i < arr_int.Length; i++)
            {
                if (i % 5 == 0)
                    Console.WriteLine();

                Console.Write($"{arr_int[i]}\t");
            }
        }
    }
}
