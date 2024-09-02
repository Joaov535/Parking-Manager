using ParkingManager.Data;

namespace ParkingManager.Models;

public abstract class CustomModel
{
    protected readonly AppDbContext Context;

    public CustomModel(AppDbContext context)
    {
        Context = context;
    }
}