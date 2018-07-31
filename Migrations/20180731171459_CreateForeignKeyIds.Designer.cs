﻿// <auto-generated />
using System;
using HomiesAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HomiesAPI.Migrations
{
    [DbContext(typeof(HomiesContext))]
    [Migration("20180731171459_CreateForeignKeyIds")]
    partial class CreateForeignKeyIds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("HomiesAPI.Models.CheckIn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HomieId");

                    b.Property<DateTime>("Time");

                    b.Property<bool>("WithGuest");

                    b.HasKey("Id");

                    b.HasIndex("HomieId");

                    b.ToTable("CheckIns");
                });

            modelBuilder.Entity("HomiesAPI.Models.CheckOut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HomieId");

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.HasIndex("HomieId");

                    b.ToTable("CheckOuts");
                });

            modelBuilder.Entity("HomiesAPI.Models.Homie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("HasGuest");

                    b.Property<bool>("IsHome");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<int>("LocationId");

                    b.Property<string>("NickName");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Homies");
                });

            modelBuilder.Entity("HomiesAPI.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AreaCode")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("DisplayName");

                    b.Property<string>("HouseNumber")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Street")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("HomiesAPI.Models.CheckIn", b =>
                {
                    b.HasOne("HomiesAPI.Models.Homie", "Homie")
                        .WithMany("CheckIns")
                        .HasForeignKey("HomieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HomiesAPI.Models.CheckOut", b =>
                {
                    b.HasOne("HomiesAPI.Models.Homie", "Homie")
                        .WithMany("CheckOuts")
                        .HasForeignKey("HomieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HomiesAPI.Models.Homie", b =>
                {
                    b.HasOne("HomiesAPI.Models.Location", "Location")
                        .WithMany("Homies")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
