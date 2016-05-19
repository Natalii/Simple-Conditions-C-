using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDToBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter USD:");
            var usd = double.Parse(Console.ReadLine());
            var bgn = Math.Round(usd * 1.79549,2);
            Console.WriteLine("The bgn is:{0}",bgn);
        }
    }
}
