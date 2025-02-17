﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_Estes.Models;

#nullable disable

namespace Mission06_Estes.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20250215214824_Initial3")]
    partial class Initial3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.12");

            modelBuilder.Entity("Mission06_Estes.Models.Movie", b =>
                {
                    b.Property<int>("movieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("movieCategory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("movieDirector")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool?>("movieEdited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("movieLentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("movieNotes")
                        .HasColumnType("TEXT");

                    b.Property<string>("movieRating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("movieTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("movieYear")
                        .HasColumnType("INTEGER");

                    b.HasKey("movieID");

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
