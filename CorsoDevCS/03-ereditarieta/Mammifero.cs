using System;

namespace _03_ereditarieta
{
    public class Mammifero : Animale
    {
        public int GiorniGestazione { get; set; }

        public Mammifero() : base()
        {
            this.SangueCaldo = true;
        }

        public Mammifero(string specie) : base(specie)
        {
            this.SangueCaldo = true;
        }

        public override void StampaInformazioni()
        {
            base.StampaInformazioni();
            Console.WriteLine($"La gestazione avviene in {GiorniGestazione} giorni.");
        }
    }
}
