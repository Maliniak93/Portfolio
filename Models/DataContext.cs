using Microsoft.EntityFrameworkCore;

namespace Portfolio.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
            public DbSet<Projects> Projects { get; set; }
    }
}



