using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of the square:");
            var sideofSquare = int.Parse(Console.ReadLine());
            Console.WriteLine("The area of the square is {0} the perimeter iis {1}", sideofSquare*sideofSquare,4*sideofSquare );
       }
    }
}