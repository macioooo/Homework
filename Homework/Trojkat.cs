using System;

namespace Homework
{
    public class Trojkat
    {
        static bool CzyTrojkat(int a, int b, int c)
        {
            return (c >= a && c >= b && a + b > c) ||
                   (a >= c && a >= b && b + c > a) ||
                   (b >= a && b >= c && a + c > b);
        }

        static bool CzySkalenny (int a, int b, int c)
        {
            return CzyTrojkat(a, b, c) && (a != b && a != c && b != c);
        }

        static bool CzyRownoramienny (int a, int b, int c)
        {
            return CzyTrojkat(a, b, c) && (a == b || a == c || b == c);
        }

        static bool CzyRownoboczny (int a, int b, int c)
        {
            return CzyTrojkat(a, b, c) && (a == b && a == c);
        }
        public static void SprawdzTrojkat (int bokA, int bokB, int bokC)
        {
            Console.WriteLine($"Czy Trójkąt: {CzyTrojkat(bokA, bokB, bokC)}");
            Console.WriteLine($"Czy Skalenny: {CzySkalenny(bokA, bokB, bokC)}");
            Console.WriteLine($"Czy Równoramienny: {CzyRownoramienny(bokA, bokB, bokC)}");
            Console.WriteLine($"Czy Równoboczny: {CzyRownoboczny(bokA, bokB, bokC)}");
        }
    }
}
