namespace esercizio_04.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ECommerce : DbContext
    {
        // Your context has been configured to use a 'ECommerce' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'esercizio_04.Models.ECommerce' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ECommerce' 
        // connection string in the application configuration file.
        public ECommerce()
            : base("name=ECommerce")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ECommerce>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Ordine> Ordini { get; set; }
        public virtual DbSet<RigaOrdine> RigheOrdine { get; set; }
    }
}