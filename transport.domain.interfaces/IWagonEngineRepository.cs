using transport.domain.core;
using transport.domain.core.Mechanical;
using transport.domain.core.Mechanical.modules.Engine;

namespace transport.domain.interfaces;

public interface IWagonEngineRepository<T>
{
    public Task<Engine<T>?> GetByModelAsync(string model);
    public Task AddAsync(EntityMetaData entityMetaData, EngineSpecification<FuelType> specification);
}