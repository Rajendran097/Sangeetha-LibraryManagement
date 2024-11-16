using librarymanagmentsystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace librarymanagmentsystem.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<Book> books { get; set; }
        public DbSet<Author> author { get; set; }
        public DbSet<Category> category { get; set; }

    }
}
