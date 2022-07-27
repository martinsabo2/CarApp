using CarApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarApp.Data;

public class CarContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<Trip> Trips { get; set; }

    const string connectionString = 
        "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=CarAppData";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(connectionString);
    }
}
