using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_03
{
    public class AutoDb: DbContext
    {
        public AutoDb() : base("name=CorsoCS")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AutoDb>());
        }

        public virtual DbSet<Automobile> Automobili { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Automobile>()
                .Property(e => e.Marca)
                .IsUnicode(false);

            modelBuilder.Entity<Automobile>()
                .Property(e => e.Modello)
                .IsUnicode(true);
        }
    }
}
