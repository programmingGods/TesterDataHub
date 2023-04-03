using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GenerateEntityWinForms;

public partial class DataHub8Context : DbContext
{
    public DataHub8Context()
    {
    }

    public DataHub8Context(DbContextOptions<DataHub8Context> options)
        : base(options)
    {
    }

    public virtual DbSet<InfoV1> InfoV1s { get; set; }

    public virtual DbSet<User1> User1s { get; set; }

    public virtual DbSet<UserInfoV1> UserInfoV1s { get; set; }

    public virtual DbSet<UserInfoV2> UserInfoV2s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=DataHub_8;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InfoV1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Info_v1__3214EC073294B48B");

            entity.ToTable("Info_v1");

            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.Value).HasMaxLength(250);
        });


        modelBuilder.Entity<User1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User_1__3214EC07D1F7E7B2");

            entity.ToTable("User_1");

            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<UserInfoV1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserInfo__3214EC07303D1AD6");

            entity.ToTable("UserInfo_v1");

            entity.HasOne(d => d.User).WithMany(p => p.UserInfoV1s)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_UserInfo_v1_Info_v1");

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.UserInfoV1s)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_UserInfo_v1_User_1");
        });

        modelBuilder.Entity<UserInfoV2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserInfo__3214EC07E91F87A0");

            entity.ToTable("UserInfo_v2");

            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.Value).HasMaxLength(250);

            entity.HasOne(d => d.User).WithMany(p => p.UserInfoV2s)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_UserInfo_v2_User_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
