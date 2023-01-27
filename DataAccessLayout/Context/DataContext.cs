using DataAccessLayout.Models;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayout.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<CompanyUsers> CompanyUsers { get; set; }
        public DbSet<Companies> Companies { get; set; }
    }
}