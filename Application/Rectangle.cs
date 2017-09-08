using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
   
    public class Rectangle : IShape
        {
            double x, y = 0;
            Point center = new Point(0,0);
            public Rectangle(double x, double y) {
                    this.x = x;
                    this.y = y;
            }
            public void Area()
            {
            Console.WriteLine("The rentangle area is: {0}.", x * y);
            }

            public void Perimeter()
            {
            Console.WriteLine("The rentangle perimeter is: {0}.", 2 * x + 2 * y);
            }
        }
    }
