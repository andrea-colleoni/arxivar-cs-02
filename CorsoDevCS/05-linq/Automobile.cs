using System;

namespace _05_linq
{
    class Automobile
    {
		public string Marca { get; set; }
		public string Modello { get; set; }
		public int Cilindrata { get; set; }
		public float CapacitaSerbatoio { get; set; }
		public float LivelloCarburante { get; set; }
		public float ConsumoKmLitro { get; set; }

		private bool autoAccesa;

        public Automobile(string marca, string modello, int cilindrata, float capacita, float consumo)
        {
			this.Marca = marca;
			this.Modello = modello;
			this.Cilindrata = cilindrata;
			this.CapacitaSerbatoio = capacita;
			this.ConsumoKmLitro = consumo;
			this.autoAccesa = false;
        }

		public void Rifornimento(float litri)
		{
			if (this.LivelloCarburante + litri > this.CapacitaSerbatoio)
            {
				Console.WriteLine("Troppo carburante!!");
				return;
            }
			this.autoAccesa = true;
			this.LivelloCarburante += litri;
		}
		public void Viaggio(int kilometri)
		{
			var l = kilometri / this.ConsumoKmLitro;
			if ( this.autoAccesa && l > this.LivelloCarburante)
            {
				Console.WriteLine($"{this.Marca} {this.Modello} ha finito il carburante!!");
				this.autoAccesa = false;
				return;
            }
			if (this.autoAccesa)
			{
				this.LivelloCarburante -= l;
				Console.WriteLine($"{this.Marca} {this.Modello} ha viaggiato per {kilometri} km e consulmato {l} lt. di carburante. {this.LivelloCarburante} lt. rimangono nel serbatoio.");
			}
			else
			{
				Console.WriteLine($"{this.Marca} {this.Modello} è spenta.");
			}
		}
	}
}
