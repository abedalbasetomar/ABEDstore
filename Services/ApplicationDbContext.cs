using ABEDstore.Models;
using Microsoft.EntityFrameworkCore;

namespace ABEDstore.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Pruducts { get; set; }
    }
}
