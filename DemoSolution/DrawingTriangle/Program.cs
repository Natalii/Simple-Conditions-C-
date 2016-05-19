using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter symbol:");
            char symbol = (char)Console.Read();
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i <height; i++)
            {
                Console.WriteLine(new string(symbol,i));
            }
        }
    }
}
