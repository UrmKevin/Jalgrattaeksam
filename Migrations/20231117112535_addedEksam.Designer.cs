﻿// <auto-generated />
using System;
using Jalgrattaeksam.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jalgrattaeksam.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231117112535_addedEksam")]
    partial class addedEksam
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Jalgrattaeksam.Models.Eksam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Aeg")
                        .HasColumnType("datetime2");

                    b.Property<string>("Eksamineerija")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Koha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Eksam");
                });
#pragma warning restore 612, 618
        }
    }
}
