using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_lesson
{
    /// <summary>
    /// Функция хэширования строки
    /// </summary>
    class HashFunction
    {
        public int HashMetod(string str)
        {
            int[] arr = new int[str.Length];
            int sum = 0;

            for ( int i=0; i<str.Length; i++)
            {
                arr[i] = (int) str[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
    }
}
