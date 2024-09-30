namespace Bookstore.Data
{
    using Bookstore.Models;
    using Microsoft.EntityFrameworkCore;

    public class BookstoreDBContext : DbContext
    {
        public BookstoreDBContext(DbContextOptions<BookstoreDBContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Price = 10.99m,
                    Genre = "Classic"
                },
                new Book
                {
                    Id = 2,
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    Price = 7.99m,
                    Genre = "Fiction"
                },
                new Book
                {
                    Id = 3,
                    Title = "1984",
                    Author = "George Orwell",
                    Price = 8.99m,
                    Genre = "Dystopian"
                }
            );
        }
    }

}
