using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesDAL
{
    public class Lab29Context : DbContext
    {
        public Lab29Context()
        {

        }

        public Lab29Context(DbContextOptions<Lab29Context> options) : base(options)
        {

        }

        public virtual DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AODEQ1G\\SQLEXPRESS;Database=Lab29DB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed(modelBuilder);
            modelBuilder.Entity<Movie>();
        }
        public static void Seed(ModelBuilder model)
        {
            model.Entity<Movie>()
                .HasData(new Movie[]
                {
                    new Movie()
                    {
                        Id = 1,
                        Title = "Shrek",
                        Genre = "Comedy"
                    },
                    new Movie()
                    {
                        Id = 2,
                        Title = "James Bond",
                        Genre = "Action"
                    },
                    new Movie()
                    {
                        Id = 3,
                        Title = "Lord of the Rings",
                        Genre = "Fantasy"
                    },
                    new Movie()
                    {
                        Id = 4,
                        Title = "Star Wars",
                        Genre = "Science Fiction"
                    },
                    new Movie()
                    {
                        Id = 5,
                        Title = "Star Trek",
                        Genre = "Science Fiction"
                    },
                    new Movie()
                    {
                        Id = 6,
                        Title = "Austin Powers",
                        Genre = "Comedy"
                    },
                    new Movie()
                    {
                        Id = 7,
                        Title = "John Wick",
                        Genre = "Action"
                    },
                    new Movie()
                    {
                        Id = 8,
                        Title = "The Avengers",
                        Genre = "Action"
                    },
                    new Movie()
                    {
                        Id = 9,
                        Title = "Willow",
                        Genre = "Fantasy"
                    },
                    new Movie()
                    {
                        Id = 10,
                        Title = "Ace Ventura: Pet Detective",
                        Genre = "Comedy"
                    },
                });
        }
    }
}