using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{   /// <summary>
    /// Координаты точки
    /// </summary>
    struct Point
    {
        // int x;
        //int y;
        public int i
        {
            get; set;
        }
        public int j
        {
            get; set;
        }
        public Point(int i, int j)
        {
            this.i = i;
            this.j = j;
           // this.val = val;
        }
       
        //public int val
        //{
        //    get; set;
        //}

    }
}
