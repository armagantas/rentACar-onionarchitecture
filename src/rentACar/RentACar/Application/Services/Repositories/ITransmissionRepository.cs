using Core.Persistence.Repositories;
using Domain.Entities;

public interface ITransmissionRepository : IAsyncRepository<Transmission, Guid>, IRepository<Transmission, Guid>
{
}
