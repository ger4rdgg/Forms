﻿// <auto-generated />
using Forms.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Forms.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230922132929_InitialDatabaseSetup")]
    partial class InitialDatabaseSetup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Forms.Data.Models.Form", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("pregunta1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pregunta2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pregunta3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("respuesta1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("respuesta2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("respuesta3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Form");
                });
#pragma warning restore 612, 618
        }
    }
}
