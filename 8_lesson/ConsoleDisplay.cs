using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_lesson
{
    class ConsoleDisplay
    {
        public void OutputOnDisplay(int[] arr_int)
        {
            for (int i = 0; i < arr_int.Length; i++)
            {
                if (i % 8 == 0)
                    Console.WriteLine();

                Console.Write($"{arr_int[i]}\t");
            }
        }
    }
}
