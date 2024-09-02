using ParkingManager.Data;

namespace ParkingManager.Models;

public class Spot : CustomModel
{
    public Guid Id { get; init; }
    public int TotalSpots { get; private set; }
    public int FreeSpots { get; private set; }
    public Vehicle? OccupantVehicle;

    public Spot(AppDbContext context) : base(context)
    {
        Id = Guid.NewGuid();
    }

    public bool IsFull()
    {
        return TotalSpots - FreeSpots == 0;
    }

    public void OccupySpot(Vehicle vehicle)
    {
        if (IsFull()) throw new Exception("O estacionamento está cheio");

        OccupantVehicle = vehicle;
        FreeSpots--;
    }
}