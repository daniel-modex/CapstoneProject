﻿// <auto-generated />
using System;
using BookingApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookingApi.Migrations
{
    [DbContext(typeof(BookingDBContext))]
    [Migration("20241115163012_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookingApi.Models.BookingDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("BookingRequestedSuccessfully")
                        .HasColumnType("bit");

                    b.Property<string>("BookingStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CancelationConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("PaymetSuccessful")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProfessionalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceProvided")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ServiceProviderResponse")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookingDetails");
                });

            modelBuilder.Entity("BookingApi.Models.BookingResponse", b =>
                {
                    b.Property<int>("ResponseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResponseId"));

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<bool>("CancallationResponse")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ServiceResponse")
                        .HasColumnType("bit");

                    b.Property<bool>("paymentResponse")
                        .HasColumnType("bit");

                    b.HasKey("ResponseId");

                    b.ToTable("BookingResponse");
                });
#pragma warning restore 612, 618
        }
    }
}
