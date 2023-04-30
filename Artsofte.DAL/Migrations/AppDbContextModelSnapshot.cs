﻿// <auto-generated />
using System;
using Artsofte.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Artsofte.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Artsofte.DAL.Models.Departament", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departaments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5487ec23-ca3e-48f5-b269-76750ce8d0c1"),
                            Floor = 4,
                            Name = "AI"
                        },
                        new
                        {
                            Id = new Guid("778342d4-d285-446b-b61f-45777dfc1261"),
                            Floor = 5,
                            Name = "Analytics"
                        },
                        new
                        {
                            Id = new Guid("fdce7ce6-712f-40fc-b4d0-79fe2d20767c"),
                            Floor = 3,
                            Name = "GameDev"
                        });
                });

            modelBuilder.Entity("Artsofte.DAL.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<Guid>("DepartamentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProgrammingLanguageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.HasIndex("ProgrammingLanguageId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Artsofte.DAL.Models.ProgrammingLanguage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProgrammingLanguages");

                    b.HasData(
                        new
                        {
                            Id = new Guid("681bd6db-ab50-414f-9131-3d239c25af41"),
                            Name = "C#"
                        },
                        new
                        {
                            Id = new Guid("6e74d219-589c-49b0-9c4a-954e0029d521"),
                            Name = "C++"
                        },
                        new
                        {
                            Id = new Guid("ae0db73e-e8ed-4c20-b80b-9c5e0b59d45b"),
                            Name = "Python"
                        },
                        new
                        {
                            Id = new Guid("5a71d13c-9111-462c-94d7-a8ee4a71a8dd"),
                            Name = "Scala"
                        },
                        new
                        {
                            Id = new Guid("13939561-3327-41f6-909c-2a09c48e82b3"),
                            Name = "Go"
                        },
                        new
                        {
                            Id = new Guid("9139235e-fb1e-4ba3-92b7-46462aa3c443"),
                            Name = "JavaScript"
                        },
                        new
                        {
                            Id = new Guid("0766f8b1-83d1-476f-996b-6d8abe5af6ba"),
                            Name = "Кумир"
                        });
                });

            modelBuilder.Entity("Artsofte.DAL.Models.Employee", b =>
                {
                    b.HasOne("Artsofte.DAL.Models.Departament", "Departament")
                        .WithMany()
                        .HasForeignKey("DepartamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Artsofte.DAL.Models.ProgrammingLanguage", "ProgrammingLanguage")
                        .WithMany()
                        .HasForeignKey("ProgrammingLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departament");

                    b.Navigation("ProgrammingLanguage");
                });
#pragma warning restore 612, 618
        }
    }
}
