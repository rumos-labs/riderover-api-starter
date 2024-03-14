using RideRover.Api.Models;

using Microsoft.AspNetCore.Mvc;

namespace RideRover.Api.Controllers;

[ApiController]
[Route("api/v1/bookings")]
public class BookingsController : ControllerBase
{
    // TODO: Inject the repositories
    public BookingsController()
    {
    }

    [HttpGet]
    public ActionResult<IEnumerable<Booking>> Get()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public ActionResult<Booking> Get(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPost]
    public ActionResult<Booking> Post(Booking booking)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public ActionResult<Booking> Put(int id, Booking booking)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    [HttpPatch("{id}")]
    public ActionResult<Booking> Patch(int id, int carId)
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

    [HttpPost("{id}/payments")]
    public ActionResult<Booking> Pay(int id, Payment payment)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }
}
