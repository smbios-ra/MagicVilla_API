﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230216053124_SeedVillaTableWithCreatedDate")]
    partial class SeedVillaTableWithCreatedDate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("sqft")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 16, 11, 1, 24, 583, DateTimeKind.Local).AddTicks(1044),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa author sit amet.",
                            ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg",
                            Name = "Royal Villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            sqft = 550
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 16, 11, 1, 24, 583, DateTimeKind.Local).AddTicks(1057),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa author sit amet.",
                            ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg",
                            Name = "Premium Pool Villa",
                            Occupancy = 4,
                            Rate = 300.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            sqft = 550
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 16, 11, 1, 24, 583, DateTimeKind.Local).AddTicks(1060),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa author sit amet.",
                            ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg",
                            Name = "Luxury Pool Villa",
                            Occupancy = 4,
                            Rate = 400.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            sqft = 750
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 16, 11, 1, 24, 583, DateTimeKind.Local).AddTicks(1062),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa author sit amet.",
                            ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg",
                            Name = "Diamond Villa",
                            Occupancy = 4,
                            Rate = 550.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            sqft = 900
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 16, 11, 1, 24, 583, DateTimeKind.Local).AddTicks(1065),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque massa author sit amet.",
                            ImageUrl = "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg",
                            Name = "Diamond Pool Villa",
                            Occupancy = 4,
                            Rate = 600.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            sqft = 1100
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
