using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Agency.Models;

public partial class AgencyDbContext : DbContext
{
    public AgencyDbContext()
    {
    }

    public AgencyDbContext(DbContextOptions<AgencyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Adre> Adres { get; set; }

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
        modelBuilder.Entity<Adre>(entity =>
        {
            entity.HasKey(e => e.IdAdres).HasName("PK__ADRES__AD91EFC5C4576D6E");

            entity.ToTable("ADRES");

            entity.Property(e => e.IdAdres).HasColumnName("ID_adres");
            entity.Property(e => e.ApartNom)
                .HasMaxLength(60)
                .HasColumnName("Apart_nom");
            entity.Property(e => e.City).HasMaxLength(60);
            entity.Property(e => e.HomeNom)
                .HasMaxLength(60)
                .HasColumnName("Home_nom");
            entity.Property(e => e.Metro)
                .HasMaxLength(8)
                .HasDefaultValueSql("('не рядом')");
            entity.Property(e => e.Street).HasMaxLength(60);
        });

        modelBuilder.Entity<Apartment>(entity =>
        {
            entity.HasKey(e => e.KadastrNom).HasName("PK__APARTMEN__D958E5502EE5C542");

            entity.ToTable("APARTMENT");

            entity.Property(e => e.KadastrNom)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Kadastr_nom");
            entity.Property(e => e.CountRooms).HasColumnName("Count_rooms");
            entity.Property(e => e.Furniture)
                .HasMaxLength(4)
                .HasDefaultValueSql("('нет')");
            entity.Property(e => e.GeneralSpace).HasColumnName("General_space");
            entity.Property(e => e.IdAdres).HasColumnName("ID_adres");
            entity.Property(e => e.IdOwner).HasColumnName("ID_owner");
            entity.Property(e => e.LiveSpace).HasColumnName("Live_space");
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.TypeBuild)
                .HasMaxLength(10)
                .HasColumnName("Type_build");
            entity.Property(e => e.YearBuild).HasColumnName("Year_build");

            entity.HasOne(d => d.IdAdresNavigation).WithMany(p => p.Apartments)
                .HasForeignKey(d => d.IdAdres)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APARTMENT_ADRES");

            entity.HasOne(d => d.IdOwnerNavigation).WithMany(p => p.Apartments)
                .HasForeignKey(d => d.IdOwner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APARTMENT_OWNER");
        });

        modelBuilder.Entity<Buyer>(entity =>
        {
            entity.HasKey(e => e.IdBuyer).HasName("PK__BUYER__7CE40798EF74449A");

            entity.ToTable("BUYER");

            entity.HasIndex(e => e.PassportNumBuyer, "UQ__BUYER__9FBDDF0076AC6F29").IsUnique();

            entity.HasIndex(e => e.NomTelBuyer, "UQ__BUYER__E5D8C86DB3DE02D5").IsUnique();

            entity.Property(e => e.IdBuyer).HasColumnName("ID_buyer");
            entity.Property(e => e.LoginBuyer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Login_buyer");
            entity.Property(e => e.NameBuyer)
                .HasMaxLength(50)
                .HasColumnName("Name_buyer");
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
            entity.Property(e => e.SurnameBuyer)
                .HasMaxLength(50)
                .HasColumnName("Surname_buyer");
        });

        modelBuilder.Entity<Deal>(entity =>
        {
            entity.HasKey(e => e.KodDeal).HasName("PK__DEAL__895C7B226E057DA9");

            entity.ToTable("DEAL");

            entity.Property(e => e.KodDeal).HasColumnName("Kod_deal");
            entity.Property(e => e.DataDeal)
                .HasColumnType("date")
                .HasColumnName("Data_deal");
            entity.Property(e => e.IdBuyer).HasColumnName("ID_buyer");
            entity.Property(e => e.IdSpec).HasColumnName("ID_spec");
            entity.Property(e => e.KadastrNom)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Kadastr_nom");

            entity.HasOne(d => d.IdBuyerNavigation).WithMany(p => p.Deals)
                .HasForeignKey(d => d.IdBuyer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APARTMENT_BUYER");

            entity.HasOne(d => d.IdSpecNavigation).WithMany(p => p.Deals)
                .HasForeignKey(d => d.IdSpec)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEAL_SPECIALIST");

            entity.HasOne(d => d.KadastrNomNavigation).WithMany(p => p.Deals)
                .HasForeignKey(d => d.KadastrNom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APARTMENT_DEAL");
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.IdOwner).HasName("PK__OWNER__97C8A80E1AEE1B43");

            entity.ToTable("OWNER");

            entity.HasIndex(e => e.PassportNumOwner, "UQ__OWNER__9E7EEF95C65CAE82").IsUnique();

            entity.HasIndex(e => e.NomTelOwner, "UQ__OWNER__BD061FB3ED6CABEE").IsUnique();

            entity.Property(e => e.IdOwner).HasColumnName("ID_owner");
            entity.Property(e => e.LoginOwner)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Login_Owner");
            entity.Property(e => e.NameOwner)
                .HasMaxLength(50)
                .HasColumnName("Name_owner");
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
            entity.Property(e => e.SurnameOwner)
                .HasMaxLength(50)
                .HasColumnName("Surname_owner");
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.IdReq).HasName("PK__REQUEST__182A645208D850EB");

            entity.ToTable("REQUEST");

            entity.Property(e => e.IdReq).HasColumnName("ID_req");
            entity.Property(e => e.DataReq)
                .HasColumnType("date")
                .HasColumnName("Data_req");
            entity.Property(e => e.IdBuyer).HasColumnName("ID_buyer");
            entity.Property(e => e.KadastrNom)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Kadastr_nom");

            entity.HasOne(d => d.IdBuyerNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.IdBuyer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REQUEST_BUYER");

            entity.HasOne(d => d.KadastrNomNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.KadastrNom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REQUEST_APARTMENT");
        });

        modelBuilder.Entity<Specialist>(entity =>
        {
            entity.HasKey(e => e.IdSpec).HasName("PK__SPECIALI__FAB5F42281184CA1");

            entity.ToTable("SPECIALIST");

            entity.HasIndex(e => e.NomTelSpec, "UQ__SPECIALI__70DC04A8FC85A3EA").IsUnique();

            entity.HasIndex(e => e.PassportSpec, "UQ__SPECIALI__8CDB1ED95CD2BA94").IsUnique();

            entity.Property(e => e.IdSpec).HasColumnName("ID_spec");
            entity.Property(e => e.CountDeals).HasColumnName("Count_deals");
            entity.Property(e => e.LoginSpec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Login_Spec");
            entity.Property(e => e.NameSpec)
                .HasMaxLength(50)
                .HasColumnName("Name_spec");
            entity.Property(e => e.NomTelSpec)
                .HasMaxLength(12)
                .HasColumnName("NomTel_Spec");
            entity.Property(e => e.PassportSpec)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("Passport_Spec");
            entity.Property(e => e.PasswordSpec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Password_Spec");
            entity.Property(e => e.SalarySpec)
                .HasComputedColumnSql("([Count_deals]*(5000)+(20000))", true)
                .HasColumnName("Salary_Spec");
            entity.Property(e => e.SurnameSpec)
                .HasMaxLength(50)
                .HasColumnName("Surname_spec");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
