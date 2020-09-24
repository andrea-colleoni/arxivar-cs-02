using System;
using System.Collections.Generic;
using System.Linq;

namespace Esercizio_02
{
    class Program
    {
        // soluzione dell'esercizio 2
        static void Main(string[] args)
        {
            var regioni = new List<Regione>();
            var lomb = new Regione { Nome = "Lombardia", AreaGeografica = AreaGeografica.Nord };
            regioni.Add(lomb);
            regioni.Add(new Regione { Nome = "Lazio", AreaGeografica = AreaGeografica.Centro });
            regioni.Add(new Regione { Nome = "Sicilia", AreaGeografica = AreaGeografica.Isole });

            var citta = new List<Citta>();
            citta.Add(new Citta { Nome = "Bergamo", Estensione = 800, Popolazione = 1000, Provincia = "BG", Regione = lomb });
            citta.Add(new Citta { Nome = "Brescia", Estensione = 1200, Popolazione = 2000, Provincia = "BS", Regione = lomb });
            citta.Add(new Citta { Nome = "Milano", Estensione = 700, Popolazione = 10000, Provincia = "MI", Regione = regioni[0] });
            citta.Add(new Citta { Nome = "Como", Estensione = 1000, Popolazione = 800, Provincia = "CO", Regione = regioni[0] });

            var lazio = regioni.Where(r => r.Nome == "Lazio").First();
            citta.Add(new Citta { Nome = "Roma", Estensione = 2000, Popolazione = 3000, Provincia = "RM", Regione = lazio });
            citta.Add(new Citta { Nome = "Latina", Estensione = 1100, Popolazione = 600, Provincia = "LT", Regione = lazio });
            citta.Add(new Citta { Nome = "Viterbo", Estensione = 900, Popolazione = 500, Provincia = "VI", Regione = regioni[1] });

            citta.Add(new Citta { Nome = "Palermo", Estensione = 1300, Popolazione = 1100, Provincia = "PA", Regione = regioni[2] });
            citta.Add(new Citta { Nome = "Trapani", Estensione = 1100, Popolazione = 900, Provincia = "TR", Regione = regioni[2] });
            citta.Add(new Citta { Nome = "Messina", Estensione = 900, Popolazione = 800, Provincia = "ME", Regione = regioni[2] });
            citta.Add(new Citta { Nome = "Catania", Estensione = 1200, Popolazione = 1400, Provincia = "CT", Regione = regioni[2] });

            // L'estensione totale della lombardia
            var estLomb = citta.Where(c => c.Regione.Nome == "Lombardia").Select(c => c.Estensione).Sum();
            // La popolazione totale della Sicilia
            var popSic = citta.Where(c => c.Regione.Nome == "Sicilia").Select(c => c.Popolazione).Sum();
            // La popolazione totale delle citta che hanno un'estensione maggiore di 1000
            var popGrandi = citta.Where(c => c.Estensione > 1000).Select(c => c.Popolazione).Sum();
            // L'elenco delle citta che hanno un'estensione maggiore della media delle estensioni della propria regione
            var medieEstensioni = citta
                .GroupBy(
                    c => c.Regione, 
                    c => c.Estensione, 
                    (reg, ext) => new { Regione = reg, MediaEstensione = ext.Average() }
                );
            var citGrandi = citta.Where(c => c.Estensione > medieEstensioni.Where(me => me.Regione == c.Regione).First().MediaEstensione);

            // risultati
            Console.WriteLine($"- l'estensione della lombardia è {estLomb}");
            Console.WriteLine($"----------");
            Console.WriteLine($"- la popolazione della sicilia è {popSic}");
            Console.WriteLine($"----------");
            Console.WriteLine($"- la popolazione delle città grandi è {popGrandi}");
            Console.WriteLine();
            Console.WriteLine($"========================================");
            Console.WriteLine();
            Console.WriteLine($"** elenco delle città grandi: **");
            foreach(var c in citGrandi)
            {
                Console.WriteLine($"- {c.Nome}: estensione => {c.Estensione}");
            }
            Console.WriteLine($"----------");
            Console.WriteLine($"** estensione media per regione: **");
            foreach (var m in medieEstensioni)
            {
                Console.WriteLine($"- {m.Regione.Nome}: estensione media => {m.MediaEstensione}");
            }
        }
    }
}
