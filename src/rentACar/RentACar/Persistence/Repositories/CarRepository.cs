using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

public class CarRepository : EfRepositoryBase<Car, Guid, BaseDbContext>, ICarRepository
{
    public CarRepository(BaseDbContext context) : base(context)
    {

    }
}

