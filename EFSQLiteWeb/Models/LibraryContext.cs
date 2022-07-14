using EFSQLiteWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace EFSQLiteWeb.Models
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; } 

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {

        }
    }
}
