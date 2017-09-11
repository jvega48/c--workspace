using System;

namespace Application
{
    public class Point : IShape {

        //point fields
        private double x;
        private double y;

        public Point(double x, double y) {
            this.x = x;
            this.y = y;
        }
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }

        public void Area() {
            System.Console.WriteLine("The area of a point is {0}", 0);
        }

        public void Perimeter() {
            System.Console.WriteLine("The perimeter of a point is {0}", 0);
        }
    }
 
}
