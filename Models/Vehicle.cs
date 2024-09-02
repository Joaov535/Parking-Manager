using ParkingManager.Data;

namespace ParkingManager.Models;

public class Vehicle : CustomModel
{
    public Vehicle(AppDbContext context, string manufacturer, string model, string color, string plate) : base(context)
    {
        Id = Guid.NewGuid();
        Manufacturer = manufacturer;
        Model = model;
        Color = color;
        Plate = plate;
    }

    public Guid Id { get; init; }
    public string Manufacturer { get; init; }
    public string Model { get; init; }
    public string Color { get; init; }
    public string Plate { get; init; }


}