﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SignUpmain.Migrations
{
    [DbContext(typeof(dbContext))]
    partial class dbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Prodotti");
                });

            modelBuilder.Entity("Prenotazione", b =>
                {
                    b.Property<string>("Prenotazioneid")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cognome")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataNascita")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ruolo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sesso")
                        .HasColumnType("TEXT");

                    b.HasKey("Prenotazioneid");

                    b.ToTable("Ordinamenti");
                });

            modelBuilder.Entity("Purchasing", b =>
                {
                    b.Property<int>("Purchasingid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantita")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nomeProdotto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Purchasingid");

                    b.ToTable("Utenti");
                });
#pragma warning restore 612, 618
        }
    }
}