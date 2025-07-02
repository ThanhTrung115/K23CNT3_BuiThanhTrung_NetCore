using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BuiThanhTrung_2310900108.Models;

public partial class BttDbContext : DbContext
{
    public BttDbContext()
    {
    }

    public BttDbContext(DbContextOptions<BttDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BttEmployee> BttEmployees { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=KAMPF;Database=BuiThanhTrung_2310900108;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BttEmployee>(entity =>
        {
            entity.HasKey(e => e.BttEmpId).HasName("PK__BttEmplo__6C37B20B935927D7");

            entity.ToTable("BttEmployee");

            entity.Property(e => e.BttEmpId)
                .ValueGeneratedNever()
                .HasColumnName("bttEmpId");
            entity.Property(e => e.BttEmpLevel).HasColumnName("bttEmpLevel");
            entity.Property(e => e.BttEmpName)
                .HasMaxLength(100)
                .HasColumnName("bttEmpName");
            entity.Property(e => e.BttEmpStartDate).HasColumnName("bttEmpStartDate");
            entity.Property(e => e.BttEmpStatus).HasColumnName("bttEmpStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
