﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission5_ear69.Models;

namespace Mission5_ear69.Migrations
{
    [DbContext(typeof(MoiveAppContext))]
    partial class MoiveAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Mission5_ear69.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Television"
                        });
                });

            modelBuilder.Entity("Mission5_ear69.Models.MovieResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edit")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 2,
                            Director = "Seth Rogen/EvenGoldberg",
                            Edit = false,
                            Lent = "no",
                            Notes = "Funny film",
                            Rating = "R",
                            Title = "This is the End",
                            Year = 2013
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 3,
                            Director = "Robert Eggers",
                            Edit = false,
                            Lent = "no",
                            Notes = "Willem Dafoe is the best actor",
                            Rating = "R",
                            Title = "LightHouse",
                            Year = 2019
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 3,
                            Director = "Daniel Brothers",
                            Edit = false,
                            Lent = "no",
                            Notes = "The best movie ever made",
                            Rating = "R",
                            Title = "Everything Everywhere All At Once",
                            Year = 2022
                        });
                });

            modelBuilder.Entity("Mission5_ear69.Models.MovieResponse", b =>
                {
                    b.HasOne("Mission5_ear69.Models.Category", "CategoryName")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryName");
                });
#pragma warning restore 612, 618
        }
    }
}
