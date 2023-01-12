using System;
using System.Collections.Generic;
using ClothingStore.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.DbConnection;

public partial class MegaDbContext : DbContext
{
    public MegaDbContext()
    {
    }

    public MegaDbContext(DbContextOptions<MegaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Clothers> Clothes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=194.67.105.79:5432;Database=mega_db;Username=mega_user;Password=679");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Clothers>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("clothes_pkey");

            entity.ToTable("clothes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
