

using ParkingManager.Data;

namespace ParkingManager.Models;

public class Parking : CustomModel
{
    public Guid Id { get; init; }
    public required string Name;

    public Parking(AppDbContext context) : base(context)
    {
        Id = Guid.NewGuid();
    }

    public required ICollection<Spot> Spots { get; set; }
}