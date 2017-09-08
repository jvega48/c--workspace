using System;

namespace Application
{
    public class Point : IShape { 
    //points properties
    private double x = 0;
    private double y = 0;


    //constructor with x,y properties
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public void Area()
    {
            Console.WriteLine("The area of the point is: {0}.", x * y);
    }

    public void Perimeter()
    {
            Console.WriteLine("The perimeter of the point is: {0}.", 2 * x + 2 * y);   
    }
}
}
