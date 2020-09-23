using System;
using System.Collections.Generic;
using System.Text;

namespace _03_ereditarieta
{
    public class Animale
    {
        public string Specie { get; set; }
        public bool Estinto { get; set; }

        public bool SangueCaldo { get; set; }

        public Animale()
        {
            this.Estinto = true;
            this.SangueCaldo = false;
        }

        public Animale(string specie)
        {
            this.Estinto = true;
            this.SangueCaldo = false;
            this.Specie = specie;
        }

        public virtual void StampaInformazioni()
        {
            Console.WriteLine($"La specie {this.Specie} {(this.Estinto ? "" : "non ")}è esitinta");
        }
    }
}
