using DatabaseAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAccess
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Books;Integrated Security=True;")
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}
