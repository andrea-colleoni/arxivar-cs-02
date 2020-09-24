using System;
using System.Collections.Generic;
using System.Text;

namespace Esercizio_02
{
    public class Citta
    {
        public string Nome { get; set; }
        public string Provincia { get; set; }
        public Regione Regione { get; set; }
        public float Estensione { get; set; }
        public float Popolazione { get; set; }
    }
}
