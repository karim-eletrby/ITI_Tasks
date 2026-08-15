using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_oop
{
    internal class Square:Rectangle
    {
        public Square(points p1,points p2):base (p1,p2)
        {
        }
        public override double Calculate_Area()
        {
            double l1 = Math.Abs((top.x - bottom.x));
            double l2 = Math.Abs((top.y - bottom.y));
            double area = l1 * l2;
            return area;
        }

    }
}
