using System;

namespace Homework
{
    public class ZadaniePiate
    {
        public static void zadaniePiate()
        {
            for (int i = 100; i > 0; i--)
            {
                if (i % 3 == 0 && i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
