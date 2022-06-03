using Microsoft.EntityFrameworkCore;
#nullable disable
namespace Assigment1.Models
{
    public class Context: DbContext
    {
      public Context(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
