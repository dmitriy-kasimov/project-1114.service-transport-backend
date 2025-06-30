using transport.domain.core;
using transport.domain.core.Overland.modules.Axis;

namespace transport.domain.interfaces;

public interface IWagonAxisRepository<T>
{
    public Task<Axis<T>?> GetByModelAsync(string model);
    public Task AddAsync(EntityMetaData entityMetaData, AxisSpecification<T> axisSpecification);
}