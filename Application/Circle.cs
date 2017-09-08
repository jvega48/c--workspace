using System;

namespace Application
{
    public class Circle : IShape
    {
        //Point center = new Point();
        public double pie = Math.PI;
        public double radius;

        public Circle(double radius) {
            this.radius = radius;
        }

        public void Area()
        {
            
            System.Console.WriteLine("The erea of the circle is: {0}." , pie * (radius * radius));
        }

        public void Perimeter()
        {

            System.Console.WriteLine("The perimeter of the circle is: {0}." , 2 * radius * pie);
        }


    }
}
