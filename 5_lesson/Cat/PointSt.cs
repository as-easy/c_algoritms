using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{   /// <summary>
    /// Данная структура содержит в себе координаты точки и её значение в Стеке
    /// </summary>
    struct PointSt
    {
        public int i
        {
            get; set;
        }
        public int j
        {
            get; set;
        }
        public int count
        {
            get; set;
        }
        public PointSt(int i, int j, int count)
        {
            this.i = i;
            this.j = j;
            this.count = count;
            // this.val = val;
        }
    }
}
