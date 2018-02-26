using LibraryProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataAccess
{
    public class LibraryProjectDbContext : DbContext
    {
        public LibraryProjectDbContext()
            : base("LibraryProjectDb")
        {

        }

        DbSet<Book> Books { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<BookLoan> BookLoans { get; set; }
    }
}
