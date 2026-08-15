using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_oop
{
    internal class Circle:Shape
    {
        public double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Calculate_Area()
        {
            return  Math.PI * Math.Pow(radius, 2);
        }
    }
}
