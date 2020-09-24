using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ef_forms
{
    public class Database : DbContext
    {
        public Database()
            : base("name=CorsoCS")
        {
        }

        public virtual DbSet<Citta> Citta { get; set; }
        public virtual DbSet<Regione> Regioni { get; set; }

    }
}
