using System;

namespace _03_ereditarieta
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammifero zebra = new Mammifero("Zebra");
            Animale passero = new Animale("Passero");
            Rettile dino = new Rettile();

            // polimorfismo
            Animale cavallo = new Mammifero("Cavallo");
            // type inference del compilatore
            var fido = new Mammifero("Cane");

            // cavallo.GiorniGestazione = 320; => illegale
            fido.GiorniGestazione = 150;

            dino.Specie = "T-Rex";

            zebra.Estinto = false;
            cavallo.Estinto = false;
            zebra.GiorniGestazione = 300;

            passero.Estinto = false;

            zebra.StampaInformazioni();
            fido.StampaInformazioni();
            cavallo.StampaInformazioni();
            passero.StampaInformazioni();
            dino.StampaInformazioni();

        }
    }
}
