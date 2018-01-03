using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_lesson
{
    class Sort
    {
        /// <summary>
        /// Задание 2. Быстрая сортировка Хоара. Входят функции QuickSort и Partition
        /// </summary>
        /// <param name="array"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public void QuickSort(ref int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = Partition(array, start, end);
            QuickSort(ref array, start, pivot - 1);
            QuickSort(ref array, pivot + 1, end);
        }

        int Partition(int[] array, int start, int end) 
        {
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i] <= array[end])
                {
                    int temp = array[marker]; // swap
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            return marker - 1;
        }
        /// <summary>
        /// Задание 3. Сортировка слиянием. Входят функции MergeSort и Merge
        /// </summary>
        public void MergeSort(ref int[] m, int l, int r)
        {
            int t;
            if (l < r)
            {    // Обрабатываемый фрагмент массива состоит более,
                // чем из одного элемента
                if ((r - l) == 1)
                {
                    if (m[r] < m[l])
                    // обрабатываемый фрагмент массива состоит из двух элементов
                    {
                        t = m[l];
                        m[l] = m[r];
                        m[r] = t;
                    }
                }
                else
                { // Разбиваем заданный фрагмент на два массива
                  // Рекурсивно вызываем функции MergeSort
                    MergeSort(ref m, l, l + (r - l) / 2);
                    MergeSort(ref m, l + ((r - l) / 2) + 1, r);
                    Merge(ref m, l, r); // Сливаем массивы;  
                }
            }
            else return;
        }

        public void Merge (ref int[] m, int l, int r) 
        {
            List<int> m1 = new List<int>();
            List<int> m2 = new List<int>();

            for (int i = l; i<= l+ (r-l)/2; i++)
            {
                m1.Add(m[i]);
            }

            for (int i = (l + (r - l) / 2) +1; i <= r; i++)
            {
                m2.Add(m[i]);
            }


            int a = 0, b = 0;
            int[] merged = new int[m1.Count + m2.Count];

            for (int i = 0; i < m1.Count + m2.Count; i++)
            {
                if (b < m2.Count && a < m1.Count)
                    if (m1[a] > m2[b])
                        merged[i] = m2[b++];
                    else //if int go for
                        merged[i] = m1[a++];
                else
                    if (b < m2.Count)
                    merged[i] = m2[b++];
                else
                    merged[i] = m1[a++];
            }

            for (int i = l; i <= r; i++)
                m[i] = merged[i - l];
        }
    }
}
