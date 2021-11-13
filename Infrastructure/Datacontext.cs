using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected overide void OnModelCreating(ModelBuilder model)
        {
            base.onMOdelCreatiog(modelBuilder);
            modelBuilder.Entity<Owner>().Property(x => x.Id).HasDefaultValue("NEWID()")

            modelBuilder.Entity<PortfolioItem>().Property(x=>x.Id).HasDefaultValue("NEWID()")
        }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<PortfolioItem> PortfolioItem { get; set; }
        
    }
}
