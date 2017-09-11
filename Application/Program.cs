using System;
using System.Collections.Generic;


namespace Application
{   
  
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            List<IShape> items = new List<IShape>();
            Point point = new Point(2,4);
            Circle circle = new Circle(point);
            Rectangle rectangle = new Rectangle(point);
            items.Add(point);
            items.Add(circle);
            items.Add(rectangle);
            foreach (IShape i in items) {
                i.Area();
                i.Perimeter();
            }
            Console.Read();
        }
    }
}
