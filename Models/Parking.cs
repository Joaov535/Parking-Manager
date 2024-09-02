

using ParkingManager.Data;

namespace ParkingManager.Models;

public class Parking : CustomModel
{
    public Guid Id;
    public required string Name;

    public Parking(AppDbContext context) : base(context)
    {
    }

    public required ICollection<Spot> Spots { get; set; }
}