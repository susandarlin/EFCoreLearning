using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCoreLearning.DataAccess.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AddressCustomer> AddressCustomers { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerRank> CustomerRanks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.HseId);

            entity.Property(e => e.HseId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HSE_ID");
            entity.Property(e => e.AsgnSttsInd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ASGN_STTS_IND");
            entity.Property(e => e.CnclDist)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CNCL_DIST");
            entity.Property(e => e.EngDist)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENG_DIST");
            entity.Property(e => e.HseDirCd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HSE_DIR_CD");
            entity.Property(e => e.HseFracNbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HSE_FRAC_NBR");
            entity.Property(e => e.HseNbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HSE_NBR");
            entity.Property(e => e.Lat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAT");
            entity.Property(e => e.Lon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LON");
            entity.Property(e => e.Pin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PIN");
            entity.Property(e => e.Pind)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PIND");
            entity.Property(e => e.StrNm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STR_NM");
            entity.Property(e => e.StrSfxCd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STR_SFX_CD");
            entity.Property(e => e.StrSfxDirCd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STR_SFX_DIR_CD");
            entity.Property(e => e.UnitRange)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_RANGE");
            entity.Property(e => e.XCoordNbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("X_COORD_NBR");
            entity.Property(e => e.YCoordNbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Y_COORD_NBR");
            entity.Property(e => e.ZipCd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZIP_CD");
        });

        modelBuilder.Entity<AddressCustomer>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.CustomerId, "IX_AddressCustomers_CustomerId");

            entity.Property(e => e.AddressId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Address).WithMany().HasForeignKey(d => d.AddressId);

            entity.HasOne(d => d.Customer).WithMany().HasForeignKey(d => d.CustomerId);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasIndex(e => e.CustomerRankId, "IX_Customers_CustomerRankId");

            entity.HasOne(d => d.CustomerRank).WithMany(p => p.Customers).HasForeignKey(d => d.CustomerRankId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
