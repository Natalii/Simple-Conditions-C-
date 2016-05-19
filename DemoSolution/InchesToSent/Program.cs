using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToSent
{
    class InchesToSent
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var inch = double.Parse(Console.ReadLine());
            var cent = inch * 2.54;
            Console.Write("centemeters = ");
            Console.WriteLine(cent);
        }
    }
}
