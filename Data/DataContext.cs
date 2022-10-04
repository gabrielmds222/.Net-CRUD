using Microsoft.EntityFrameworkCore;
using CrudDotnet.Models;

namespace CrudDotnet.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {

        }
    }
}