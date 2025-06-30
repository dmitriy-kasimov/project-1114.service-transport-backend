using Microsoft.EntityFrameworkCore;
using transport.domain.core;
using transport.domain.core.Mechanical;
using transport.domain.core.Mechanical.modules.Engine;
using transport.domain.core.Overland;
using transport.domain.core.Overland.modules.Axis;
using transport.domain.interfaces;
using transport.infrastructure.data.WagonAxisRepository.Models;

namespace transport.infrastructure.data.WagonAxisRepository;

public class WagonAxisRepository : IWagonAxisRepository<AxisVariant>
{
    private readonly WagonAxisDbContext _dbContext = new();

    public async Task<Axis<AxisVariant>?> GetByModelAsync(string model)
    {
        var result = await _dbContext.WagonAxis
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Model == model);


        if (result == null) return null;
        
        var metaData = new EntityMetaData("SOME_GUID", result.Model, result.Name);
        var specification = new AxisSpecification<AxisVariant>(result.Axis);
        return new Axis<AxisVariant>(metaData, specification, []);
    }
    
    public async Task AddAsync(EntityMetaData entityMetaData, AxisSpecification<AxisVariant> specification)
    {
        var z = new AxisEntity<AxisVariant>
        {
            Model = entityMetaData.Model,
            Name = entityMetaData.Name,
            Axis = specification.Axis,
        };
        await _dbContext.AddAsync(z);
        await _dbContext.SaveChangesAsync();
    }
}