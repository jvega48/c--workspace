using System;

namespace Application
{
    public class Circle : IShape
    {
        //Point object called center passed into circle
        Point center;

        //constants and fields for the circle class 
        public double area , radius, perimete = 0;
        public const double PIE = Math.PI;
        //public double X { get { return center.X; } set { center.X = X; } }
        //public double Y { get{ return center.Y; } set { center.Y = Y; } }
        
        //Circle constructor that takes a @param of a point from the class point that assigns the (x,y) point
        public Circle(Point p) {

            this.center = p;
        }
        //void method that makes the caculations and displays the area based on the formula
        // x^2 + y^2 = r 
        //then we do a Pie * radius ^2
        //giving us the area of the circle 
        public void Area(){
            radius = Math.Pow(center.X, 2)  + Math.Pow(center.Y, 2);
            area = Math.Round(PIE * Math.Pow(radius, 2), 2);
            System.Console.WriteLine("The area of the circle is: {0}", area);   
        }

        //void method that makes the calculations and displays the perimeter based on the 
        //the radius that's being displayed 
        public void Perimeter()
        {
            radius = Math.Pow(center.X, 2) + Math.Pow(center.Y, 2);
            perimete = Math.Round(2 * PIE * radius, 2);
            System.Console.WriteLine("The perimeter of the circle is: {0}", perimete);
        }
    }
}
