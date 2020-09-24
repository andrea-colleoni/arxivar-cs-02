using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ef
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new CorsoCS();

            foreach(var p in db.Persone.Where(p => p.AltezzaInCm != null))
            {
                Console.WriteLine($"Nome: {p.Nome}, Cognome: {p.Cognome}");
            }

            // db.Persone.Add(new Persone { Nome = "Luigio", Cognome = "Verdi", PesoInKg = 90.2 });
            db.Tabella.Add(new Tabella { IdTabella = 1, Campo = "ciao" });
            db.SaveChanges();
            Console.ReadLine();
        }
    }
}
