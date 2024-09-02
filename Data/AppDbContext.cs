using ParkingManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ParkingManager.Data;

public class AppDbContext : DbContext
{
    public DbSet<Parking> Parking { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Parking.db");
        base.OnConfiguring(optionsBuilder);
    }
}