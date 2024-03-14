using RideRover.Api.Models;

namespace RideRover.Api.Repositories;

public class CarsRepository : IRepository<Car>
{
    private readonly RideRoverDbContext context;

    public CarsRepository(RideRoverDbContext context)
    {
        this.context = context;
    }

    public Car Add(Car entity)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public Car? Get(int id)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public IEnumerable<Car> GetAll()
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public void Update(Car entity)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }
}
