using System;

namespace Application
{
 
   public class Rectangle : IShape
    {
        Point center;
        public double area, perimeter = 0;
        //public double X { get { return center.X; } set { center.X = X; } }
        //public double Y { get { return center.Y; } set { center.Y = Y; }}
        public Rectangle(Point p){
            this.center = p;
        }

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
