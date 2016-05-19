using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeMinutes
{
    class TimePlusMin
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int changehours = hours;
            int changemin = minutes +15;
            
            if (changemin>59)
            {
                changemin = changemin % 60;
                changehours++;
                if (changehours > 23)
                {
                    changehours = 0;
                }
            }
            Console.WriteLine("{0}:{1:00}",changehours,changemin);
        }
    }
}
