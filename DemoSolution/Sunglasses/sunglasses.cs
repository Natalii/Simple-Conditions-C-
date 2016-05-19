using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int glass = n * 2;
            int middle = n;

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)

                {
                    Console.Write(new string('*', glass));
                    Console.Write(new string(' ', n));
                    Console.Write(new string('*', glass));

                }
                else if (i < n /2 || i > n / 2)
                {
                    Console.Write('*');
                    Console.Write(new string('/', glass - 2));
                    Console.Write('*');
                    Console.Write(new string(' ', n));
                    Console.Write('*');
                    Console.Write(new string('/', glass - 2));
                    Console.Write('*');

                }
                else if (i == n / 2)
                {
                    Console.Write('*');
                    Console.Write(new string('/', glass - 2));
                    Console.Write('*');
                    Console.Write(new string('|', n));
                    Console.Write('*');
                    Console.Write(new string('/', glass - 2));
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
