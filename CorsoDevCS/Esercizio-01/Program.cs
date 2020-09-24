using System;
using System.Collections.Generic;

namespace Esercizio_01
{
    class Program
    {
        // variabile statica (di classe)
        public static int x;

        // variabile d'istanza
        int y;

        static void Main(string[] args)
        {
            // da un contesto statico non posso accedere a variabili o metodi d'istanza
            // y = 10;
            var prg = new Program();
            prg.y = 10;

            // accesso a un membro di classe
            Program.x = 10;

            // var automobili = new List<Automobile>();
            //automobili.Add(new Automobile("Fiat", "Tipo", 1500, 34, 18));
            //automobili.Add(new Automobile("Alfa Romeo", "Giulia", 2000, 45, 13));
            //automobili.Add(new Automobile("Lancia", "Y", 1200, 38, 19));

            var automobili = new Dictionary<string, Automobile>();
            automobili.Add("tipo", new Automobile("Fiat", "Tipo", 1500, 34, 18));
            automobili.Add("giulia", new Automobile("Alfa Romeo", "Giulia", 2000, 45, 13));
            automobili.Add("y", new Automobile("Lancia", "Y", 1200, 38, 19));

            // var contains = auto.Contains(null);

            foreach (var auto in automobili.Values)
            {
                auto.Rifornimento(new Random().Next(10, (int)auto.CapacitaSerbatoio));
                // l'operazione di cast ad intero di un decimale tronca il decimale
            }
            var kmViaggio = 380;
            const int stepKm = 20;

            while (kmViaggio > 0)
            {
                foreach (var auto in automobili.Values)
                {
                    auto.Viaggio(stepKm);
                }
                kmViaggio -= stepKm;
            }

            Console.WriteLine($"Il livello di carb della Y è {automobili["y"].LivelloCarburante}");

        }
    }
}
