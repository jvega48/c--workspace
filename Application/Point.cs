using System;

namespace Application
{
    public class Point : IShape {

        //private point fields
        private double x;
        private double y;
        //point constructor with @param double x @param double y coordinates 
        public Point(double x, double y) {
            this.x = x;
            this.y = y;
        }
        //getter and setter for the @param x & y coordinates
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }

        //simple void methods to display the area and perimeter
        public void Area() {
            System.Console.WriteLine("The area of a point is {0}", 0);
        }

        public void Perimeter() {
            System.Console.WriteLine("The perimeter of a point is {0}", 0);
        }
    }
 
}
