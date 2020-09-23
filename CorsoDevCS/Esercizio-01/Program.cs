using System;
using System.Collections.Generic;

namespace Esercizio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var automobili = new List<Automobile>();
            automobili.Add(new Automobile("Fiat", "Tipo", 1500, 34, 18));
            automobili.Add(new Automobile("Alfa Romeo", "Giulia", 2000, 45, 13));
            automobili.Add(new Automobile("Lancia", "Y", 1200, 38, 19));

            // var contains = auto.Contains(null);

            foreach (var auto in automobili)
            {
                auto.Rifornimento(new Random().Next(10, (int)auto.CapacitaSerbatoio));
                // l'operazione di cast ad intero di un decimale tronca il decimale
            }
            var kmViaggio = 380;
            const int stepKm = 20;

            while (kmViaggio > 0)
            {
                foreach (var auto in automobili)
                {
                    auto.Viaggio(stepKm);
                }
                kmViaggio -= stepKm;
            }

        }
    }
}
