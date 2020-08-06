using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PeiLiu.BudgetTacker.Core.Entities;

namespace PeiLiu.BudgetTacker.Infrastructure.Data
{
    public class BudgetTrackerDbContext : DbContext
    {
        public BudgetTrackerDbContext(DbContextOptions<BudgetTrackerDbContext> options) : base(options)
        {
        }

        public DbSet<Incomes> Incomes { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Expenditures> Expenditures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(ConfigureUsers);
            modelBuilder.Entity<Incomes>(ConfigureIncomes);
            modelBuilder.Entity<Expenditures>(ConfigureExpenditures);  

        }

        private void ConfigureExpenditures(EntityTypeBuilder<Expenditures> modelBuilder)
        {
            modelBuilder.Property(i => i.Amount).HasColumnType("decimal(18, 2)");
        }

        private void ConfigureIncomes(EntityTypeBuilder<Incomes> modelBuilder)
        {
            modelBuilder.Property(i => i.Amount).HasColumnType("decimal(18, 2)");
        }

        private void ConfigureUsers(EntityTypeBuilder<Users> modelBuilder)
        {
            modelBuilder.Property(u => u.Email).IsRequired();
            modelBuilder.Property(u => u.Password).IsRequired();
        }
    }
}
