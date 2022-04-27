using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class NorthwindContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}