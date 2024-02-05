using Core.Persistence.Repositories;
using Domain.Entities;

public interface ICarRepository : IAsyncRepository<Car, Guid>, IRepository<Car, Guid>
{
}
