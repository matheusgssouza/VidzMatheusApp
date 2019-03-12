using Microsoft.EntityFrameworkCore;
using VidzMatheus.API.Models;

namespace VidzMatheus.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
            
        public DbSet<Value> values { get; set; }
    }
}