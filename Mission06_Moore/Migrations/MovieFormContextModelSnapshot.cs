﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_Moore.Models;

#nullable disable

namespace Mission06_Moore.Migrations
{
    [DbContext(typeof(MovieFormContext))]
    partial class MovieFormContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Mission06_Moore.Models.Application", b =>
                {
                    b.Property<int>("ApplicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RatingId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApplicationID");

                    b.HasIndex("RatingId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("Mission06_Moore.Models.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RatingName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RatingId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            RatingId = 1,
                            RatingName = "G"
                        },
                        new
                        {
                            RatingId = 2,
                            RatingName = "PG"
                        },
                        new
                        {
                            RatingId = 3,
                            RatingName = "PG-13"
                        },
                        new
                        {
                            RatingId = 4,
                            RatingName = "R"
                        });
                });

            modelBuilder.Entity("Mission06_Moore.Models.Application", b =>
                {
                    b.HasOne("Mission06_Moore.Models.Rating", "Rating")
                        .WithMany()
                        .HasForeignKey("RatingId");

                    b.Navigation("Rating");
                });
#pragma warning restore 612, 618
        }
    }
}
