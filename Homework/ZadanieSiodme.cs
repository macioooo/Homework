using System;

namespace Homework
{
    public class ZadanieSiodme
    {
        public static void zadanieSiodme()
        {
            int i = 100;
            do
            {
                if (i % 3 == 0 && i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i--;
            }
            while (i > 0);
        }
    }
}
