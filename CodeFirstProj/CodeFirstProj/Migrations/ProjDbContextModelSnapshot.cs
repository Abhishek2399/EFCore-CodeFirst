﻿// <auto-generated />
using CodeFirstProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstProj.Migrations
{
    [DbContext(typeof(ProjDbContext))]
    partial class ProjDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CodeFirstProj.Models.Employee", b =>
                {
                    b.Property<int>("Eid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ESal")
                        .HasColumnType("int");

                    b.HasKey("Eid");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CodeFirstProj.Models.Location", b =>
                {
                    b.Property<int>("Lid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Lname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Lid");

                    b.ToTable("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}
