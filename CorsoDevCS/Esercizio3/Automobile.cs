using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Esercizio_03
{
	[Table("AUTOMOBILE")]
    public class Automobile
    {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("ID_AUTOMOBILE")]
        public int IdAutomobile { get; set; }
		[Required]
		[StringLength(30)]
		[Column("MARCA")]
		public string Marca { get; set; }
		[Required]
		[StringLength(30)]
		[Column("MODELLO")]
		public string Modello { get; set; }
		[Column("CILINDRATA")]
		public int? Cilindrata { get; set; }
		[Column("CAPACITA_SERBATOIO")]
		public float? CapacitaSerbatoio { get; set; }
		[Column("LIVELLO_CARBURANTE")]
		public float? LivelloCarburante { get; set; }
		[Column("CONSUMO_KM")]
		public float? ConsumoKmLitro { get; set; }
		
		private bool autoAccesa;

        public Automobile()
        {

        }

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
