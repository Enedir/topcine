﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TopCine.Infra.ORM.Context;

namespace TopCine.Infra.ORM.Migrations
{
    [DbContext(typeof(TopCineProcessContext))]
    [Migration("20200219013930_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("process")
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TopCine.Domain.Features.Users.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessLevel")
                        .HasColumnName("AccessLevel");

                    b.Property<string>("Email")
                        .HasColumnName("Email")
                        .HasMaxLength(30);

                    b.Property<DateTime>("InsertDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("InsertDate")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .HasColumnName("Password")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnName("UpdateDate");

                    b.HasKey("Id")
                        .HasName("Id");

                    b.ToTable("TBUsers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AccessLevel = 0,
                            Email = "admin.test@printwayy.com",
                            InsertDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Admin",
                            Password = "827ccb0eea8a706c4c34a16891f84e7b"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
