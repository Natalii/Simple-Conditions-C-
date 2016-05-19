using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProspectInHospitality
{
    class Program
    {
        static void Main(string[] args)
        {
            uint NumberOfBuilders = uint.Parse(Console.ReadLine());
            uint NumberOfRecepcionists = uint.Parse(Console.ReadLine());
            uint NumberOfChambermaids = uint.Parse(Console.ReadLine());
            uint NumberOfTechnichans = uint.Parse(Console.ReadLine());
            uint NumberOfOthers = uint.Parse(Console.ReadLine());

            decimal NiKiSalaryUSD = decimal.Parse(Console.ReadLine());
            decimal rateUSD = decimal.Parse(Console.ReadLine());
            decimal mysalary = decimal.Parse(Console.ReadLine());
            decimal totalbuget = decimal.Parse(Console.ReadLine());

            //salaries
            decimal builders = 1500.04m;
            decimal recepsionist = 2102.10m; 
            decimal chambermaids = 1465.46m; 
            decimal technicians = 2053.33m; 
            decimal others = 3010.98m;

            //niki salary

            decimal nikisalBGN = NiKiSalaryUSD * rateUSD;
            decimal allMoneyNeeded = 
                NumberOfBuilders * builders + 
                NumberOfRecepcionists * recepsionist + 
                NumberOfChambermaids * chambermaids + 
                NumberOfTechnichans * technicians + 
                NumberOfOthers * others + 
                mysalary + 
                nikisalBGN;
           
            Console.WriteLine("The amount is: {0} lv.", Math.Round(allMoneyNeeded,2));

            decimal moneyLeft = (Math.Abs(totalbuget - allMoneyNeeded));
            moneyLeft = Math.Round(moneyLeft, 2);
            if (allMoneyNeeded <= totalbuget)
            {

                Console.WriteLine("YES \\ Left: {0} lv.",moneyLeft);
            }
            else
            {
                Console.WriteLine("NO \\ Need more: {0} lv.",moneyLeft);
            }
        }
    }
}
