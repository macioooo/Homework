using System;
using static System.Formats.Asn1.AsnWriter;

namespace Homework
{
    public class ZadanieDziewiate
    {

        private static float ObliczStopeProcentowa(float saldo)
        {
            float stopaProcentowa = 0.0f;

            switch (saldo)
            {
                case float s when s < 0.0f:
                    stopaProcentowa = -3.213f;
                    break;
                case float s when s < 1000.0f:
                    stopaProcentowa = 0.5f;
                    break;
                case float s when s < 5000.0f:
                    stopaProcentowa = 1.621f;
                    break;
                default:
                    stopaProcentowa = 2.475f;
                    break;
            }

            return stopaProcentowa;
        }
        private static decimal AktualizacjaSaldaRocznego(decimal saldo)
        {
            float stopaProcentowa = ObliczStopeProcentowa((float)saldo);
            decimal saldoRoczne = saldo * (decimal)(1 + stopaProcentowa / 100);
            return saldoRoczne;
        }
        private static int IleLatPrzedOczekiwanymSaldem(float posiadaneSaldo, float oczekiwaneSaldo)
        {
            int lata = 0;
            while (posiadaneSaldo < oczekiwaneSaldo)
            {
                decimal saldoRoczne = AktualizacjaSaldaRocznego((decimal)posiadaneSaldo);
                posiadaneSaldo = (float)(saldoRoczne);
                lata++;
            }
            return lata;
        }
        public static void wyswietlStopeOrazAktualizacje (float saldo)
        { 
            Console.WriteLine($"Aktualizacja salda rocznego: {AktualizacjaSaldaRocznego((decimal)saldo)}");
            Console.WriteLine($"Odsetki wynoszą: {saldo * (ObliczStopeProcentowa(saldo) / 100)}");
            Console.WriteLine($"Stopa procentowa wynosi: {ObliczStopeProcentowa(saldo)}%");
        }
        public static void wyswietlLata (float posiadaneSaldo, float oczekiwaneSaldo)
        {
            Console.Write($"Ilość lat od posiadanego salda ({posiadaneSaldo}) do oczekiwanego ({oczekiwaneSaldo}) wynosi: ");
            Console.WriteLine(IleLatPrzedOczekiwanymSaldem(posiadaneSaldo, oczekiwaneSaldo));
        }
    }
}
