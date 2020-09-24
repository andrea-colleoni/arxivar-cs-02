using System;
using System.Collections.Generic;
using System.Linq;
using _05_linq.Estensioni;

namespace _05_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var lomb = new Regione();
            lomb.Area = AreaGeografica.Nord;

            int i = 10;

            Console.WriteLine(i.ToString());
            if (i.IsGreaterThan(5))
            {
                Console.WriteLine("è più grande!");
            }

            100.IsGreaterThan(200);

            var lista = new List<string>();
            lista.Add("Milano");
            lista.Add("Brescia");
            lista.Add("Roma");
            lista.Add("Torino");
            lista.Add("Bergamo");
            lista.Add("Aosta");
            lista.Add("Napoli");

            Console.WriteLine(lista.Max());
            Console.WriteLine(lista.Min());

            var automobili = new List<Automobile>();
            automobili.Add(new Automobile("Fiat", "Tipo", 1500, 34, 18));
            automobili.Add(new Automobile("Alfa Romeo", "Giulia", 2000, 45, 13));
            automobili.Add(new Automobile("Lancia", "Y", 1200, 38, 19));
            automobili.Add(new Automobile("Renault", "Clio", 1400, 38, 19));
            automobili.Add(new Automobile("Toyota", "Yaris", 1400, 38, 23));

            // voglio conoscere la capienza complessiva dei serbatoi di tutte le mie auto
            Console.WriteLine($"la capacita complessiva è {automobili.Select(a => a.CapacitaSerbatoio).Sum()}");
            // a => a.CapacitaSerbatoio è una lambda expression e si legge: detta a l'i-esima auto 
            // estratta dall'iteratore della lista seleziono la capacita

            // voglio conoscere il consumo medio delle auto che hanno una cilindrata >= 1500
            var medio = automobili
                .Where(a => a.Cilindrata >= 1500)
                .Select(a => a.ConsumoKmLitro)
                .Average();
            Console.WriteLine($" consumo medio {medio}");

            automobili.Any(a => a.ConsumoKmLitro < 15);
            automobili.All(a => a.LivelloCarburante < 0);
            foreach (var a in automobili
                   .OrderByDescending(a => a.ConsumoKmLitro))
            {
                Console.WriteLine($"{a.Modello}: {a.ConsumoKmLitro}");
            }

            float consumoTot = 0;
            int conteggio = 0;
            foreach(var a in automobili)
            {
                if (a.Cilindrata >= 1500)
                {
                    consumoTot += a.ConsumoKmLitro;
                    conteggio++;
                }
            }
            medio = consumoTot / conteggio;
            Console.WriteLine($" consumo medio {medio}");

        }
    }
}
