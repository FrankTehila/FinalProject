using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BL.models;

public partial class dbclass : DbContext
{
    public dbclass()
    {
    }

    public dbclass(DbContextOptions<dbclass> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Employee1> Employees1 { get; set; }

    public virtual DbSet<Meeting> Meetings { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<TeamLeader> TeamLeaders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='H:\\finalProject\\FinalProject\\DAL\\Data\\database.mdf';Integrated Security=True;Connect Timeout=30;Encrypt=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC0773AEAFF1");

            entity.ToTable("Employee");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LeaderId).HasColumnName("leaderId");
        });

        modelBuilder.Entity<Employee1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC0704991A45");

            entity.ToTable("Employees");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LeaderId).HasColumnName("leaderId");
        });

        modelBuilder.Entity<Meeting>(entity =>
        {
            entity.HasKey(e => e.MeetId).HasName("PK__Meeting__4030A39665F1168E");

            entity.ToTable("Meeting");

            entity.Property(e => e.MeetId).ValueGeneratedNever();
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.NumOfRoom).HasColumnName("numOfRoom");

            entity.HasOne(d => d.NumOfRoomNavigation).WithMany(p => p.Meetings)
                .HasForeignKey(d => d.NumOfRoom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Meeting__numOfRo__4BAC3F29");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK__Room__3286393974FDADD0");

            entity.ToTable("Room");

            entity.Property(e => e.RoomId).ValueGeneratedNever();
        });

        modelBuilder.Entity<TeamLeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TeamLead__3214EC0707B20BA5");

            entity.ToTable("TeamLeader");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.NumOfWorkers).HasColumnName("numOfWorkers");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
