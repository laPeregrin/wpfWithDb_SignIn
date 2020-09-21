using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace TraderEntityFrameWork
{
    public class TraderDbContext : DbContext
    {
        public TraderDbContext(DbContextOptions options) : base(options) { }



        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AssetTransaction> AssetTransactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssetTransaction>().OwnsOne(a => a.Asset); 
            base.OnModelCreating(modelBuilder);
        }
      
    }
}
