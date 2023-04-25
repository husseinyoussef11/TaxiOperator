using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TaxiOperator.Models
{
    public partial class TaxiOperatorContext : DbContext
    {
        public TaxiOperatorContext()
        {
        }

        public TaxiOperatorContext(DbContextOptions<TaxiOperatorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Branch> Branches { get; set; } = null!;
        public virtual DbSet<BranchCab> BranchCabs { get; set; } = null!;
        public virtual DbSet<BranchCustomer> BranchCustomers { get; set; } = null!;
        public virtual DbSet<BranchDriver> BranchDrivers { get; set; } = null!;
        public virtual DbSet<Cab> Cabs { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Driver> Drivers { get; set; } = null!;
        public virtual DbSet<DriverCab> DriverCabs { get; set; } = null!;
        public virtual DbSet<MonthlyLottery> MonthlyLotteries { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=TaxiOperator;User Id=PracticeUser;Password=P@ssw0rd");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.IdBranch);

                entity.ToTable("Branch");

                entity.Property(e => e.IdBranch).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<BranchCab>(entity =>
            {
                entity.HasKey(e => e.IdBranchCab);

                entity.ToTable("BranchCab");

                entity.Property(e => e.IdBranchCab).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<BranchCustomer>(entity =>
            {
                entity.HasKey(e => e.IdBranchCustomer);

                entity.ToTable("BranchCustomer");

                entity.Property(e => e.IdBranchCustomer).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<BranchDriver>(entity =>
            {
                entity.HasKey(e => e.IdBranchDriver);

                entity.ToTable("BranchDriver");

                entity.Property(e => e.IdBranchDriver).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Cab>(entity =>
            {
                entity.HasKey(e => e.IdCab);

                entity.ToTable("Cab");

                entity.Property(e => e.IdCab).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Enginesize)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.Year)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);

                entity.ToTable("Customer");

                entity.Property(e => e.IdCustomer).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsVip).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.HasKey(e => e.IdDriver);

                entity.ToTable("Driver");

                entity.Property(e => e.IdDriver).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BirthDate)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<DriverCab>(entity =>
            {
                entity.HasKey(e => e.IdDriverCab);

                entity.ToTable("DriverCab");

                entity.Property(e => e.IdDriverCab).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateAssigned).HasMaxLength(50);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<MonthlyLottery>(entity =>
            {
                entity.HasKey(e => e.IdMonthlyLottery);

                entity.ToTable("MonthlyLottery");

                entity.Property(e => e.IdMonthlyLottery).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date).HasMaxLength(50);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.ToTable("Order");

                entity.Property(e => e.IdOrder).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Destination).HasMaxLength(1000);

                entity.Property(e => e.IsCompleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Source).HasMaxLength(1000);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
