using ParkingManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ParkingManager.Data;

public class AppDbContext : DbContext
{
    public DbSet<Parking> ParkingLots { get; set; }
    public DbSet<Spot> Spots { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=ParkingManager.db");
        base.OnConfiguring(optionsBuilder);
    }
}