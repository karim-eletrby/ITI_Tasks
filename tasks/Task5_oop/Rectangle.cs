using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_oop
{
    internal class Rectangle:Shape
    {
        public Rectangle(points p1,points p2):base(p1,p2)  
        {
            
        }
        public override double Calculate_Area()
        {
            double width = Math.Abs((top.x - bottom.x));
            double hieght = Math.Abs((top.y - bottom.y));
            double area=width*hieght;
            return area;
        }
    }
}
