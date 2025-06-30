using Microsoft.EntityFrameworkCore;
using transport.domain.core;
using transport.domain.core.Mechanical;
using transport.domain.core.Mechanical.modules.Battery;
using transport.domain.core.Mechanical.modules.Engine;
using transport.domain.interfaces;
using transport.infrastructure.data.WagonBatteryRepository.Models;
using transport.infrastructure.data.WagonEngineRepository.Models;

namespace transport.infrastructure.data.WagonBatteryRepository;

public class WagonBatteryRepository : IWagonBatteryRepository
{
    private readonly WagonBatteryDbContext _dbContext = new();

    public async Task<Battery?> GetByModelAsync(string model)
    {
        var result = await _dbContext.WagonBatteries
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Model == model);


        if (result == null) return null;
        
        var engineMetaData = new EntityMetaData("SOME_GUID", result.Model, result.Name);
        var engineSpecification = new BatterySpecification(result.MaxCharge);
        return  new Battery(engineMetaData, engineSpecification);
    }
    
    public async Task AddAsync(EntityMetaData entityMetaData, BatterySpecification specification)
    {
        var z = new BatteryEntity
        {
            Model = entityMetaData.Model,
            Name = entityMetaData.Name,
            MaxCharge = specification.MaxCharge,
        };
        await _dbContext.AddAsync(z);
        await _dbContext.SaveChangesAsync();
    }
}