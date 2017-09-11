using System;

namespace Application
{
 
   public class Rectangle : IShape
    {
        //center object from the Point class 
        Point center;
        
        //class fields area, perimeter = 0
        public double area, perimeter = 0;
        //public double X { get { return center.X; } set { center.X = X; } }
        //public double Y { get { return center.Y; } set { center.Y = Y; }}

        //Rectangle constructor that takes in a Point object this.center = p;
        public Rectangle(Point p){
            this.center = p;
        }

        //simple void methods that do the calculations and returns the values in the console
        public void Area(){
            area = (center.X * 2) * (center.Y * 2);
            System.Console.WriteLine("The area of a rectangle is {0}", area);
        }

        public void Perimeter(){
            perimeter = 2 * ((center.X * 2) + (center.Y * 2));
            System.Console.WriteLine("The perimeter of a rectangle is {0}", perimeter);
        }
    }  
}
