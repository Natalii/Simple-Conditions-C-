using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class CtoF
    {
        static void Main(string[] args)
        {
            Console.Write("Celsius:");
            var c = double.Parse(Console.ReadLine());
            //Console.Write("Fahrenheit:");
            var f = c * 9/5 +32;
            Console.WriteLine("Converted to Fahrenheit is:{0}", Math.Round(f,3));
        }
    }
}
