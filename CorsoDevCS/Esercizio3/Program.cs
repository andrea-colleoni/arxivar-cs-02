using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new AutoDb();
            //var auto = new Automobile
            //{
            //    Marca = "Ferrari",
            //    Modello = "F340",
            //    Cilindrata = 3000,
            //    ConsumoKmLitro = 1,
            //    CapacitaSerbatoio = 100
            //};

            //db.Automobili.Add(auto);
            //db.SaveChanges();
            var automobili = db.Automobili;

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

            Console.WriteLine($"Il livello di carb della Y è " +
                $"{automobili.Where(a => a.Modello == "Y").First().LivelloCarburante}");

            db.SaveChanges();

            Console.ReadLine();
        }
    }
}
