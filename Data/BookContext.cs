using Microsoft.EntityFrameworkCore;
using RazorPagesBook.Models;

namespace RazorPagesBook.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}