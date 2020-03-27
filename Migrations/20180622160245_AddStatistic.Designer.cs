﻿// <auto-generated />
using System;
using BME77.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BME77.Migrations
{
    [DbContext(typeof(PaperContext))]
    [Migration("20180622160245_AddStatistic")]
    partial class AddStatistic
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BME77.Models.Paper", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abstract");

                    b.Property<string>("Author");

                    b.Property<string>("FullTextLink");

                    b.Property<int>("SessionID");

                    b.Property<DateTime>("TimeEnd");

                    b.Property<DateTime>("TimeStart");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("SessionID");

                    b.ToTable("Paper");
                });

            modelBuilder.Entity("BME77.Models.Session", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Chair");

                    b.Property<string>("ID_C");

                    b.Property<bool>("IsBreak");

                    b.Property<bool>("IsKeyLab");

                    b.Property<bool>("IsOral");

                    b.Property<bool>("IsWorkshop");

                    b.Property<string>("Name");

                    b.Property<string>("Room");

                    b.Property<DateTime>("TimeEnd");

                    b.Property<DateTime>("TimeStart");

                    b.HasKey("ID");

                    b.ToTable("Session");
                });

            modelBuilder.Entity("BME77.Models.Statistic", b =>
                {
                    b.Property<int>("StatisticID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Page");

                    b.Property<string>("Route");

                    b.Property<DateTime>("Time");

                    b.HasKey("StatisticID");

                    b.ToTable("Statistic");
                });

            modelBuilder.Entity("BME77.Models.Paper", b =>
                {
                    b.HasOne("BME77.Models.Session", "Session")
                        .WithMany("Papers")
                        .HasForeignKey("SessionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
