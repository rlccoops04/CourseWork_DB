using System;
using System.Collections.Generic;
using Agency.Models;
using Microsoft.EntityFrameworkCore;

namespace Agency;

public partial class AgencyDbContext : DbContext
{
    public AgencyDbContext()
    {
    }

    public AgencyDbContext(DbContextOptions<AgencyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Apartment> Apartments { get; set; }

    public virtual DbSet<Buyer> Buyers { get; set; }

    public virtual DbSet<Deal> Deals { get; set; }

    public virtual DbSet<Owner> Owners { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<Specialist> Specialists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-SSS2TI2M;Database=AgencyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Apartment>(entity =>
        {
            entity.HasKey(e => e.KadastrNom).HasName("PK__APARTMEN__D958E5500F677B68");

            entity.ToTable("APARTMENT");

            entity.HasIndex(e => e.Adress, "UQ__APARTMEN__08F62FE54ABDE498").IsUnique();

            entity.Property(e => e.KadastrNom)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Kadastr_nom");
            entity.Property(e => e.Adress).HasMaxLength(60);
            entity.Property(e => e.CountRooms).HasColumnName("Count_rooms");
            entity.Property(e => e.Furniture)
                .HasMaxLength(4)
                .HasDefaultValueSql("('нет')");
            entity.Property(e => e.GeneralSpace).HasColumnName("General_space");
            entity.Property(e => e.LiveSpace).HasColumnName("Live_space");
            entity.Property(e => e.LoginOwner)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Login_Owner");
            entity.Property(e => e.Metro)
                .HasMaxLength(8)
                .HasDefaultValueSql("('не рядом')");
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.TypeBuild)
                .HasMaxLength(10)
                .HasColumnName("Type_build");
            entity.Property(e => e.YearBuild).HasColumnName("Year_build");

            entity.HasOne(d => d.LoginOwnerNavigation).WithMany(p => p.Apartments)
                .HasForeignKey(d => d.LoginOwner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APARTMENT_OWNER");
        });

        modelBuilder.Entity<Buyer>(entity =>
        {
            entity.HasKey(e => e.LoginBuyer).HasName("PK__BUYER__481D8311A85EF61D");

            entity.ToTable("BUYER");

            entity.HasIndex(e => e.PassportNumBuyer, "UQ__BUYER__9FBDDF007FFA9AC3").IsUnique();

            entity.HasIndex(e => e.NomTelBuyer, "UQ__BUYER__E5D8C86D9B22DB7F").IsUnique();

            entity.Property(e => e.LoginBuyer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Login_buyer");
            entity.Property(e => e.FioBuyer)
                .HasMaxLength(50)
                .HasColumnName("Fio_buyer");
            entity.Property(e => e.NomTelBuyer)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("NomTel_buyer");
            entity.Property(e => e.PassportNumBuyer)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("Passport_Num_buyer");
            entity.Property(e => e.PasswordBuyer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Password_buyer");
        });

        modelBuilder.Entity<Deal>(entity =>
        {
            entity.HasKey(e => e.KodDeal).HasName("PK__DEAL__895C7B22816BC87E");

            entity.ToTable("DEAL");

            entity.Property(e => e.KodDeal)
                .ValueGeneratedNever()
                .HasColumnName("Kod_deal");
            entity.Property(e => e.DataDeal)
                .HasColumnType("date")
                .HasColumnName("Data_deal");
            entity.Property(e => e.KadastrNom)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Kadastr_nom");
            entity.Property(e => e.LoginBuyer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Login_buyer");
            entity.Property(e => e.LoginSpec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Login_Spec");

            entity.HasOne(d => d.KadastrNomNavigation).WithMany(p => p.Deals)
                .HasForeignKey(d => d.KadastrNom)
                .HasConstraintName("FK_APARTMENT_DEAL");

            entity.HasOne(d => d.LoginBuyerNavigation).WithMany(p => p.Deals)
                .HasForeignKey(d => d.LoginBuyer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APARTMENT_BUYER");

            entity.HasOne(d => d.LoginSpecNavigation).WithMany(p => p.Deals)
                .HasForeignKey(d => d.LoginSpec)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEAL_SPECIALIST");
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.LoginOwner).HasName("PK__OWNER__A868A6CF66D4D7FD");

            entity.ToTable("OWNER");

            entity.HasIndex(e => e.PassportNumOwner, "UQ__OWNER__9E7EEF9536A88033").IsUnique();

            entity.HasIndex(e => e.NomTelOwner, "UQ__OWNER__BD061FB3CC2053C9").IsUnique();

            entity.Property(e => e.LoginOwner)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Login_Owner");
            entity.Property(e => e.FioOwner)
                .HasMaxLength(50)
                .HasColumnName("Fio_Owner");
            entity.Property(e => e.NomTelOwner)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("NomTel_Owner");
            entity.Property(e => e.PassportNumOwner)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("Passport_Num_Owner");
            entity.Property(e => e.PasswordOwner)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Password_Owner");
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.IdReq).HasName("PK__REQUEST__182A6452793A75DC");

            entity.ToTable("REQUEST");

            entity.Property(e => e.IdReq).HasColumnName("ID_req");
            entity.Property(e => e.CountRoomsReq).HasColumnName("Count_rooms_req");
            entity.Property(e => e.DataReq)
                .HasColumnType("date")
                .HasColumnName("Data_req");
            entity.Property(e => e.FloorReq).HasColumnName("Floor_req");
            entity.Property(e => e.FurnitureReq)
                .HasMaxLength(4)
                .HasDefaultValueSql("('нет')")
                .HasColumnName("Furniture_req");
            entity.Property(e => e.GeneralSpaceReq).HasColumnName("General_space_req");
            entity.Property(e => e.LiveSpaceReq).HasColumnName("Live_space_req");
            entity.Property(e => e.LoginBuyer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Login_buyer");
            entity.Property(e => e.MaxPriceReq)
                .HasColumnType("money")
                .HasColumnName("MaxPrice_req");
            entity.Property(e => e.MetroReq)
                .HasMaxLength(8)
                .HasDefaultValueSql("('не рядом')")
                .HasColumnName("Metro_req");
            entity.Property(e => e.TypePostrReq)
                .HasMaxLength(10)
                .HasColumnName("Type_postr_req");
            entity.Property(e => e.YearPostrReq).HasColumnName("Year_postr_req");

            entity.HasOne(d => d.LoginBuyerNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.LoginBuyer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REQUEST_BUYER");
        });

        modelBuilder.Entity<Specialist>(entity =>
        {
            entity.HasKey(e => e.LoginSpec).HasName("PK__SPECIALI__48F116870FA86323");

            entity.ToTable("SPECIALIST");

            entity.HasIndex(e => e.NomTelSpec, "UQ__SPECIALI__70DC04A8AA3238A2").IsUnique();

            entity.Property(e => e.LoginSpec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Login_Spec");
            entity.Property(e => e.CountDeals)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Count_deals");
            entity.Property(e => e.FioSpec)
                .HasMaxLength(50)
                .HasColumnName("Fio_Spec");
            entity.Property(e => e.NomTelSpec)
                .HasMaxLength(12)
                .HasColumnName("NomTel_Spec");
            entity.Property(e => e.PasswordSpec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Password_Spec");
            entity.Property(e => e.SalarySpec)
                .HasComputedColumnSql("([Count_deals]*(5000)+(20000))", true)
                .HasColumnName("Salary_Spec");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
