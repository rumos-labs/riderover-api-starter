using Microsoft.EntityFrameworkCore;

namespace RideRover.Api;

public class RideRoverDbContext : DbContext
{
    public RideRoverDbContext(DbContextOptions<RideRoverDbContext> options) : base(options) { }

    // TODO: Add DbSet properties here
}
