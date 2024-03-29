﻿// <auto-generated />
using System;
using HospitalApp.Model.MyDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalApp.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220121135745_ThirdMigration")]
    partial class ThirdMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("HospitalApp.Model.Users.RegUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<string>("Surname")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("RegUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("RegUser");
                });

            modelBuilder.Entity("HospitalApp.Model.Users.Admin", b =>
                {
                    b.HasBaseType("HospitalApp.Model.Users.RegUser");

                    b.HasDiscriminator().HasValue("Admin");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Njegoseva 2",
                            Birthday = new DateTime(1938, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Ljubinje",
                            Email = "admin@gmail.com",
                            Name = "Kosa",
                            Password = "123",
                            Phone = "059621610",
                            Surname = "Pesut"
                        });
                });

            modelBuilder.Entity("HospitalApp.Model.Users.Patient", b =>
                {
                    b.HasBaseType("HospitalApp.Model.Users.RegUser");

                    b.Property<string>("BloodType")
                        .HasColumnType("longtext");

                    b.Property<string>("HealthCard")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsBlockable")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("MedicalRecordId")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}
