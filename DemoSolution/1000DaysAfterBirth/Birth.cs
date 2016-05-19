using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime dt = DateTime.ParseExact(date, "dd'-'MM'-'yyyy", System.Globalization.CultureInfo.InstalledUICulture);

            var changedate = dt.AddDays(999);
            Console.WriteLine(changedate.ToString("dd'-'MM'-'yyyy"));
        }

    }
}