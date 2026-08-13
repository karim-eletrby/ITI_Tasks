using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_oop
{
    internal class line
    {
        points p1;
        points p2;
        public line(points p1,points p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        
        }
        public double getlength()
        {
          return   Math.Sqrt((p2.x-p1.x)*(p2.x-p1.x)+(p2.y-p1.y)*(p2.y-p1.y));
        }
    }
}
