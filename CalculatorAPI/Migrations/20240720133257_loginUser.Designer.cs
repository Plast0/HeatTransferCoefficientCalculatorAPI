﻿// <auto-generated />
using CalculatorAPI.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CalculatorAPI.Migrations
{
    [DbContext(typeof(CalculatorDbContext))]
    [Migration("20240720133257_loginUser")]
    partial class loginUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CalculatorAPI.Entity.Envelope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<decimal>("ValuU")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.HasKey("Id");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Envelopes");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.FinishingCeiling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Lambda")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Thicness")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FinishingCeilings");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.FinishingExteriorWall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Lambda")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Thicness")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FinishingExteriorWalls");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.FinishingFoundation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Lambda")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Thicness")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FinishingFoundations");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.FinishingInteriorWall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Lambda")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Thicness")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FinishingInteriorWalls");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.FinishingRoof", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Lambda")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Thicness")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FinishingRoofs");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.InsulationCeiling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Lambda")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Thicness")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("InsulationCeiling");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.InsulationFoundation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Lambda")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Thicness")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("InsulationFoundation");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.InsulationWall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Lambda")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Thicness")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("InsulationWalls");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EnvelopeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Lambda")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Thicness")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnvelopeId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.StructureCeiling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Lambda")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Thicness")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StructureCeiling");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.StructureFoundation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Lambda")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Thicness")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StructureFoundation");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.StructureRoof", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Lambda")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Thicness")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StructureRoof");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.StructureWall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Lambda")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Thicness")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StructureWalls");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConfirePassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.Envelope", b =>
                {
                    b.HasOne("CalculatorAPI.Entity.User", "User")
                        .WithOne("Envelope")
                        .HasForeignKey("CalculatorAPI.Entity.Envelope", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.Material", b =>
                {
                    b.HasOne("CalculatorAPI.Entity.Envelope", "Envelope")
                        .WithMany("Materials")
                        .HasForeignKey("EnvelopeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Envelope");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.Envelope", b =>
                {
                    b.Navigation("Materials");
                });

            modelBuilder.Entity("CalculatorAPI.Entity.User", b =>
                {
                    b.Navigation("Envelope")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
