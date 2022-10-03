using Microsoft.EntityFrameworkCore;
using CrudDotnet.Models;

namespace CrudDotnet.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlServer(connectionString:"DataSource=app.db;Cache=Shared");
    }
}