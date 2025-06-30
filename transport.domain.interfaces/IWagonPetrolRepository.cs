using transport.domain.core;
using transport.domain.core.Mechanical.modules.Petrol;

namespace transport.domain.interfaces;

public interface IWagonPetrolRepository<T>
{
    public Task<Petrol<T>?> GetByModelAsync(string model);

    public Task AddAsync(EntityMetaData entityMetaData, PetrolSpecification petrolSpecification);
}