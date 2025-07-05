using transport.domain.core;
using transport.domain.core.Mechanical;
using transport.domain.core.Mechanical.modules.Petrol;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Mappers;

public static class PetrolMapper
{
    public static Petrol<FuelType, domain.core.Wagon.Models> ToDomain(PetrolEntity petrolEntity)
    {
        var compatibleWagonModels = petrolEntity.CompatibleTransports.ConvertAll(wagon => wagon.Model);
        var metaData = new ModuleMetaData<domain.core.Wagon.Models>(petrolEntity.Name, compatibleWagonModels);
        
        var specification = new PetrolSpecification(petrolEntity.Capacity);
        
        return new Petrol<FuelType, domain.core.Wagon.Models>(metaData, specification, FuelType.Diesel);
    }
    
    public static PetrolEntity ToModel(Petrol<FuelType, domain.core.Wagon.Models> petrol, List<WagonEntity> wagonEntities)
    {
        return new PetrolEntity
        {
            Name = petrol.MetaData.Name,
            CompatibleTransports = wagonEntities,
            Capacity = petrol.Specification.Capacity,
        };
    }
}