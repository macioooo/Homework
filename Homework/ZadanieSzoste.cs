using System;

namespace Homework
{
    public class ZadanieSzoste
    {
        public static void zadanieSzoste()
        {
            int i = 100;
            while (i > 0)
            {
                if (i % 3 == 0 && i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i--;
            }
        }
    }
}
