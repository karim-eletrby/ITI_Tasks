using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class point
    {
        public double x {  get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public point()
        {
            
        }
       
        public point(double X,double Y,double Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
        public static void display(point p)
        {
            if (p != null) 
            {
                Console.WriteLine($"x:{p.x}\ny:{p.y}");
            }
        }
        public static void Distance(point p1,point p2, out double x_distance, out  double y_distance)
        {
             x_distance = (p2.x - p1.x);
             y_distance = (p2.y - p1.y);

           // return Math.Abs(x_distance);
        }
    }
}
