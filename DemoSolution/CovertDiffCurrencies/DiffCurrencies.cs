﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovertDiffCurrencies
{
    class DiffCurrencies
    {
        static void Main(string[] args)
        {
            decimal moneytoconvert = decimal.Parse(Console.ReadLine());

            string firstcurrency = Console.ReadLine();
            string secondcurrency = Console.ReadLine();

            decimal firstRate = 0.0m;
            decimal secondRate = 0.0m;

            if (firstcurrency == "BGN")
            {
                firstRate = 1;
            }
            else if (firstcurrency == "USD")
            {
                firstRate = 1.79549m;

            }
            else if(firstcurrency == "EUR")
            {
                firstRate = 1.95583m;
            }
            else if( firstcurrency == "GBP")
            {
                firstRate = 2.53405m;
            }
            if (secondcurrency == "BGN")
            {
                secondRate = 1;
            }
            else if(secondcurrency == "USD")
            {
                secondRate = 1.79549m;
            }
            else if (secondcurrency == "EUR")
            {
                secondRate = 1.95583m;
            }
            else if (secondcurrency == "GBP")
            {
                secondRate = 2.53405m;
            }
             decimal result = moneytoconvert * (firstRate / secondRate);
            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
