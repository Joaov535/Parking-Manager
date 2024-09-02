
using Microsoft.AspNetCore.Mvc;

namespace ParkingManager.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ParkingController : ControllerBase
{
    
    [HttpGet]
    public IActionResult Get()
    {
        
    }
}