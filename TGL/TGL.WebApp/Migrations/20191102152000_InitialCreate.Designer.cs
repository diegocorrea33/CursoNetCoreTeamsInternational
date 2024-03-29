﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TGL.WebApp.Data;

namespace TGL.WebApp.Migrations
{
    [DbContext(typeof(TGLContext))]
    [Migration("20191102152000_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TGL.WebApp.Models.Computer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<double>("Cpu");

                    b.Property<string>("Model");

                    b.Property<double>("Ram");

                    b.Property<Guid>("StudentId");

                    b.HasKey("Id");

                    b.ToTable("Computer");
                });

            modelBuilder.Entity("TGL.WebApp.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Age");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.Property<string>("Nit")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
