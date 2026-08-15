using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_oop
{
    internal abstract class Shape
    {
        public points top;
        public points bottom;
        protected Shape()
        {
            
        }
        public Shape(points p1, points p2)
        {
            this.top = p1;
            this.bottom = p2;
        }
        public abstract double Calculate_Area();
        
            
        
    }
}
