using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Conversion> Conversions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=conversions.db");
    }
}

