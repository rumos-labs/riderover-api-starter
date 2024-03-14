using RideRover.Api.Models;

namespace RideRover.Api.Repositories;

public class BookingsRepository : IRepository<Booking>
{
    private readonly RideRoverDbContext context;

    public BookingsRepository(RideRoverDbContext context)
    {
        this.context = context;
    }

    public Booking Add(Booking entity)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public Booking? Get(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public IEnumerable<Booking> GetAll()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public void Update(Booking entity)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }
}
