using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _7_lesson
{
    //Автор: Варанкин Владимир
    class Program
    {
        /// <summary>
        /// Задание 1. Считать матрицу смежности и вывести на экран
        /// В матрице смежности разделитель - знак табуляции, в конце файла обязателен знак перевода на новую строку
        /// <paramref name="arr_mass">Двумерный список для записи данных</paramref>/>
        /// </summary>
        static void Main()
        {
            //FileStream fs_masSm = new FileStream("Book1.txt", FileMode.OpenOrCreate, FileAccess.Read);
            FileStream fs_masSm = new FileStream("masSm.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr_masSm = new StreamReader(fs_masSm);
            //int[,] arr_masSm;//= new int [,] ();
            List<List<int>> arr_mass = new List<List<int>>();
            arr_mass.Add(new List<int>());

            char ch;
            string temp = "";
            int n = 0;

            while (!sr_masSm.EndOfStream)
            {
                ch = (char) sr_masSm.Read();
                if(ch != '\t' && ch != '\n' && ch != '\r') 
                {
                    temp += ch;
                }
                else if (ch == '\n')
                {
                    n++;
                    arr_mass.Add(new List<int>());

                }
                else
                {
                    //arr_mass.Add();
                    arr_mass[n].Add(Convert.ToInt32(temp));
                    temp = "";
                }                
            }

            sr_masSm.Close();
            fs_masSm.Close();

            for (int i = 0; i < arr_mass.Count; i++ )
            {
                for(int j = 0; j < arr_mass[i].Count; j++)
                {
                    Console.Write($"{arr_mass[i][j]}\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
