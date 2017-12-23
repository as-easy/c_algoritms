using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections;

namespace Cat
{
    /// <summary>
    /// Автор: Варанкин Владимир
    /// Задание: Поиск выхода (но не кратчайшим путем). Понял как сделать очередью только, когда сделал поиск через стек.
    /// </summary>
    class Program
    {
        /// <summary>
        /// <paramref name="pointStart">точка начала поиска</paramref>
        /// <paramref name="pointEnd">точка конца поиска</paramref>
        /// <paramref name="count">Количество шагов</paramref>
        /// <paramref name="pq">Стек пройденных точек</paramref>
        /// <paramref name="arrMap">карта, где -1 - границы лабиринта, 0 - неисследованная область, 1 - исследованная область</paramref>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i, j, count = 0;

            int[,] arrMap = new int[9, 9]{
                { -1, -1, -1, -1, -1, -1, -1, -1, -1, },
                { -1,  0,  0,  0,  0,  0,  0,  0, -1, },
                { -1,  0, -1, -1, -1, -1, -1,  0, -1, },
                { -1,  0, -1,  0,  0,  0,  0,  0, -1, },
                { -1,  0, -1, -1,  0,  0, -1, -1, -1, },
                { -1,  0,  0, -1,  0,  0,  0,  0, -1, },
                { -1,  0,  0, -1,  0, -1, -1,  0, -1, },
                { -1,  0,  0, -1,  0,  0, -1,  0, -1, },
                { -1, -1, -1, -1, -1, -1, -1, -1, -1, },
            };

            //int[,] arrMap = new int[5, 5] 
            //{
            //     { -1, -1, -1, -1, -1, },
            //     { -1,  0,  0,  0, -1, },
            //     { -1,  0, -1,  0, -1, },
            //     { -1,  0, -1,  0, -1, },
            //     { -1, -1, -1, -1, -1, },
            //};

            Point pointStart = new Point(1,1);            
            Point pointEnd = new Point(5, 2);
            Stack<PointSt> pq = new Stack<PointSt>();

            Point pointTemp = pointStart;
            i = pointStart.i;
            j = pointStart.j;
            arrMap[i, j] = 1;
            pq.Push(new PointSt(i, j, count));            

            while (pointTemp.i != pointEnd.i?true:
                                            pointTemp.j != pointEnd.j?true:false)
            {
                for (int n = 1; n <= 5; n++)
                {
                    switch (n)
                    {
                        case 1:                                                        
                            if(arrMap[pointTemp.i + 1, pointTemp.j]==0)
                            {
                                i++;
                                count++;
                                arrMap[i, j] = 1;
                                pointTemp.i = i;
                                pq.Push(new PointSt(i, j, count));
                                n = 6;
                            }
                            break;

                        case 2:
                            if (arrMap[pointTemp.i, pointTemp.j - 1] == 0)
                            {
                                j--;
                                count++;
                                arrMap[i, j] = 1;
                                pointTemp.j = j;
                                pq.Push(new PointSt(i, j, count));
                                n = 6;
                            }
                            break;

                        case 3:
                            if (arrMap[pointTemp.i - 1, pointTemp.j] == 0)
                            {
                                i--;
                                count++;
                                arrMap[i, j] = 1;
                                pointTemp.i = i;
                                pq.Push(new PointSt(i, j, count));
                                n = 6;
                            }
                            break;

                        case 4:                            
                            if (arrMap[pointTemp.i, pointTemp.j + 1] == 0)
                            {
                                j++;
                                count++;
                                arrMap[i, j] = 1;
                                pointTemp.j = j;
                                pq.Push(new PointSt(i, j, count));
                                n = 6;
                            }
                            break;

                        default:
                            pq.Pop();
                            pointTemp.i = pq.Peek().i;
                            pointTemp.j = pq.Peek().j;
                            i = pointTemp.i;
                            j = pointTemp.j;
                            count = pq.Peek().count;
                            break;
                    }
                }
            }
            Console.WriteLine($"Count = {count}");
        }
    }
}
