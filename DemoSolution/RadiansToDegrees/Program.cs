using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radian:");
            // var radian = double.Parse(Console.ReadLine());
            //var degree = Math.Round(Math.PI/radian*180,2);
            // Console.WriteLine("The degree is:" + degree);
            var radian = double.Parse(Console.ReadLine());
            var degree = (Math.PI / 180) * radian;
            Console.WriteLine("The degree is {0}:", Math.Round(degree, 2));
        }
    }
}
