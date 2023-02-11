using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Gundam.DataAccess.Entities;

public partial class GundamContext : DbContext
{
    public GundamContext()
    {
    }

    public GundamContext(DbContextOptions<GundamContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MobileSuit> MobileSuits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;userid=user;pwd=password;port=3306;database=gundam;sslmode=none", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.5.18-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("latin1_swedish_ci")
            .HasCharSet("latin1");

        modelBuilder.Entity<MobileSuit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mobile_suit");

            entity.HasIndex(e => e.GundamId, "GundamId").IsUnique();

            entity.Property(e => e.GundamId)
                .ValueGeneratedOnAdd()
                .HasColumnType("int(11)");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.Pilot)
                .HasMaxLength(50)
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
