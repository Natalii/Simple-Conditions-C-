using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1=");
            var x1 = double.Parse(Console.ReadLine());
            Console.Write("y1=");
            var y1 = double.Parse(Console.ReadLine());
            Console.Write("x2=");
            var x2 = double.Parse(Console.ReadLine());
            Console.Write("y2=");
            var y2 = double.Parse(Console.ReadLine());
            var area = Math.Abs ((x1 - x2) * (y1 - y2));
            var perimeter = 2*Math.Abs ((x1 - x2) + Math.Abs(y1 - y2));
            Console.WriteLine("The area of the rectangle is: {0}", area);
            Console.WriteLine("The perimeter of the rectangle is: {0}", perimeter);

        }
    }
}
