﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreApp.Data.Concrete;

#nullable disable

namespace StoreApp.Web.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20240322131510_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("StoreApp.Data.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Telefon",
                            Description = "Akıllı Telefon",
                            Name = "Samsung s16",
                            Price = 25000m
                        },
                        new
                        {
                            Id = 2,
                            Category = "Telefon",
                            Description = "Baya Akıllı Telefon",
                            Name = "Samsung s17",
                            Price = 26000m
                        },
                        new
                        {
                            Id = 3,
                            Category = "Telefon",
                            Description = "Çok Akıllı Telefon",
                            Name = "Samsung s18",
                            Price = 27000m
                        },
                        new
                        {
                            Id = 4,
                            Category = "Telefon",
                            Description = "En Akıllı Telefon",
                            Name = "Samsung s19",
                            Price = 28000m
                        },
                        new
                        {
                            Id = 5,
                            Category = "Telefon",
                            Description = "En En Akıllı Telefon",
                            Name = "Samsung s20",
                            Price = 29000m
                        },
                        new
                        {
                            Id = 6,
                            Category = "Telefon",
                            Description = "Senden Akıllı Telefon",
                            Name = "Samsung s21",
                            Price = 30000m
                        },
                        new
                        {
                            Id = 7,
                            Category = "Telefon",
                            Description = "yeni model Akıllı Telefon",
                            Name = "Samsung s22",
                            Price = 31000m
                        },
                        new
                        {
                            Id = 8,
                            Category = "Telefon",
                            Description = "Inanılmaz zeki ve Akıllı Telefon",
                            Name = "Samsung s23",
                            Price = 32000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
