using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("r=");
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * radius * radius;
            var perimeter = 2 * Math.PI * radius;
            //Console.WriteLine("The area is:" + area);
            //Console.WriteLine("The perimeter is:" + perimeter);
            Console.WriteLine("The area is: {0}, The perimeter is:{1}", area, perimeter);
        }
    }
}
