using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterBGNEURGBP
{
    class converter
    {
        static void Main(string[] args)
        {
            Console.Write("Enter BGN:");
            var bgn = double.Parse(Console.ReadLine());
            var usd = Math.Round(bgn / 0.554988,2);
            //Console.WriteLine("The usd is:{0}", usd);
            //Console.Write("Enter EUR:");
            var eur = Math.Round(bgn / 0.510779992, 2);
            //Console.WriteLine("The eur is:{0}", eur);
            var gbp = Math.Round(bgn / 0.390244383, 2);
            //Console.WriteLine("The usd is:{0}; The eur is:{1}; The gbp is:{2}",usd,eur, gbp);
            Console.WriteLine("The usd is:{0}", usd);
            Console.WriteLine("The eur is:{0}", eur);
            Console.WriteLine("The gbp is:{0}", gbp);

        }
    }
}
