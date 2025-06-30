using Microsoft.EntityFrameworkCore;
using transport.domain.core;
using transport.domain.core.Mechanical;
using transport.domain.core.Mechanical.modules.Engine;
using transport.domain.interfaces;
using transport.infrastructure.data.WagonEngineRepository.Models;

namespace transport.infrastructure.data.WagonEngineRepository;

public class WagonEngineRepository : IWagonEngineRepository<FuelType>
{
    private readonly WagonEngineDbContext _wagonEngineDbContext = new();

    public async Task<Engine<FuelType>?> GetByModel(string model)
    {
        var result = await _wagonEngineDbContext.WagonEngines
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Model == model);


        if (result == null) return null;
        
        var engineMetaData = new EntityMetaData("SOME_GUID", result.Model, result.Name);
        var engineSpecification = new EngineSpecification<FuelType>(result.Bsfc, result.AcceptedTypesFuel);
        return  new Engine<FuelType>(engineMetaData, engineSpecification);
    }
    
    public async Task AddAsync(EntityMetaData entityMetaData, EngineSpecification<FuelType> specification)
    {
        var z = new EngineEntity<FuelType>
        {
            Model = entityMetaData.Model,
            Name = entityMetaData.Name,
            Bsfc = specification.Bsfc,
            AcceptedTypesFuel = specification.AcceptedTypesFuel,
        };
        await _wagonEngineDbContext.AddAsync(z);
        await _wagonEngineDbContext.SaveChangesAsync();
    }
}