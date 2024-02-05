using Core.Persistence.Repositories;
using Domain.Entities;

public interface IFuelRepository : IAsyncRepository<Fuel, Guid>, IRepository<Fuel, Guid>
{
}
