namespace WcfShoesStore
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StoresInventory : DbContext
    {
        public StoresInventory()
            : base("name=StoresInventory")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Article_tbl> Article_tbl { get; set; }
        public virtual DbSet<Store_tbl> Store_tbl { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article_tbl>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Store_tbl>()
                .HasMany(e => e.Article_tbl)
                .WithRequired(e => e.Store_tbl)
                .HasForeignKey(e => e.StoreId)
                .WillCascadeOnDelete(false);
        }
    }
}
