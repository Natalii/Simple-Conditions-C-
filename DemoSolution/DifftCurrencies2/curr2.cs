using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifftCurrencies2
{
    class curr2
    {
        static void Main(string[] args)
        {
            decimal moneyconverter2 = decimal.Parse(Console.ReadLine());

           string firstcurr = Console.ReadLine();
           string secondcurr = Console.ReadLine();

            var currencies = new Dictionary<string, decimal>()
            {
                { "BGN", 1 },
                { "USD", 1.79549m},
                { "EUR", 1.95583m},
                { "GBP", 2.53405m}
            };
            //Console.WriteLine(currencies["BGN"]); 

            decimal result = moneyconverter2 * (currencies[firstcurr] / currencies[secondcurr]);
            Console.WriteLine("{0} {1}", Math.Round(result, 2), secondcurr);
           
        }
    }
}
