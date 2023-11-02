using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class ZadanieTrzecie
    {
        public static void Pierwiastek()
        {
            double a, x = 1;
            a = Double.Parse(Console.ReadLine());
            double epsilon = 0.0001;
            if (a < 0)
            {
                Console.WriteLine("Wartośc jest ujemna");
            }
            else
            {
                while (Math.Abs(x * x + a) > epsilon)
                {
                    x = (1.0 / 2.0 * (x + (a / x)));
                }
                Console.WriteLine(x);

            }
            Console.ReadKey();
        }
    }
}
