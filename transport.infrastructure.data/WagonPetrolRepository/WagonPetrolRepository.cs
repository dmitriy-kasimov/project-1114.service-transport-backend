using Microsoft.EntityFrameworkCore;
using transport.domain.core;
using transport.domain.core.Mechanical;
using transport.domain.core.Mechanical.modules.Petrol;
using transport.domain.interfaces;
using transport.infrastructure.data.WagonPetrolRepository.Models;

namespace transport.infrastructure.data.WagonPetrolRepository;

public class WagonPetrolRepository : IWagonPetrolRepository<FuelType>
{
    private readonly WagonPetrolDbContext _dbContext = new();

    public async Task<Petrol<FuelType>?> GetByModelAsync(string model)
    {
        var result = await _dbContext.WagonPetrol
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Model == model);


        if (result == null) return null;
        
        var metaData = new EntityMetaData("SOME_GUID", result.Model, result.Name);
        var specification = new PetrolSpecification(result.Capacity);
        return new Petrol<FuelType>(metaData, specification, FuelType.Octane92);
    }
    
    public async Task AddAsync(EntityMetaData entityMetaData, PetrolSpecification specification)
    {
        var z = new PetrolEntity
        {
            Model = entityMetaData.Model,
            Name = entityMetaData.Name,
            Capacity = specification.Capacity
        };
        await _dbContext.AddAsync(z);
        await _dbContext.SaveChangesAsync();
    }
}