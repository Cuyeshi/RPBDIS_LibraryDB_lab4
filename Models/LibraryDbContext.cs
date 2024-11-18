using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RPBDIS_lab4.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<LoanedBook> LoanedBooks { get; set; }
    }
}
