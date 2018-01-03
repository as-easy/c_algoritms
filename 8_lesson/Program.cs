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
            ConsoleDisplay cd = new ConsoleDisplay();
            Sort qs = new Sort();
            int[] arr_int;

            arr_int = new int[16] { 2, 1, 0, 3, 4, 7, 6, 5, 2, 1, 0, 3, 4, 7, 6, 5 };            
           // arr_int = aarr.AddArray2("AA100.txt");           
            qs.QuickSort(ref arr_int, 0, arr_int.Length - 1);
            cd.OutputOnDisplay(arr_int);
            Console.WriteLine();


            arr_int = aarr.AddArray2("AA100.txt");
            qs.MergeSort(ref arr_int, 0, arr_int.Length - 1);
            cd.OutputOnDisplay(arr_int);


        }
    }
}
