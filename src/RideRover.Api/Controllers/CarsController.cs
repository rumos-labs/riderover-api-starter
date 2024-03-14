using RideRover.Api.Models;

using Microsoft.AspNetCore.Mvc;

namespace RideRover.Api.Controllers;

[ApiController]
[Route("api/v1/cars")]
public class CarsController : ControllerBase
{
    // TODO: Inject the repositories
    public CarsController()
    {
    }

    [HttpGet]
    public ActionResult<IEnumerable<Car>> Get()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public ActionResult<Car> Get(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPost]
    public ActionResult<Car> Post(Car car)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public ActionResult<Car> Put(int id, Car car)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }
}
