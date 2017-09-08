using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{   
  
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> items = new List<IShape>();
            Point point = new Point(3,4);
            Circle circle = new Circle(10);
            Rectangle rectangle = new Rectangle(20,10);
            items.Add(point);
            items.Add(circle);
            items.Add(rectangle);
            foreach (IShape i in items) {
                i.Area();
                i.Perimeter();
              }
            Console.Read()
        }
    }
}
