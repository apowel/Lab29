﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesDAL;

namespace MoviesDAL.Migrations
{
    [DbContext(typeof(Lab29Context))]
    partial class Lab29ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MoviesDAL.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Comedy",
                            Title = "Shrek"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Action",
                            Title = "James Bond"
                        },
                        new
                        {
                            Id = 3,
                            Genre = "Fantasy",
                            Title = "Lord of the Rings"
                        },
                        new
                        {
                            Id = 4,
                            Genre = "Science Fiction",
                            Title = "Star Wars"
                        },
                        new
                        {
                            Id = 5,
                            Genre = "Science Fiction",
                            Title = "Star Trek"
                        },
                        new
                        {
                            Id = 6,
                            Genre = "Comedy",
                            Title = "Austin Powers"
                        },
                        new
                        {
                            Id = 7,
                            Genre = "Action",
                            Title = "John Wick"
                        },
                        new
                        {
                            Id = 8,
                            Genre = "Action",
                            Title = "The Avengers"
                        },
                        new
                        {
                            Id = 9,
                            Genre = "Fantasy",
                            Title = "Willow"
                        },
                        new
                        {
                            Id = 10,
                            Genre = "Comedy",
                            Title = "Ace Ventura: Pet Detective"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
