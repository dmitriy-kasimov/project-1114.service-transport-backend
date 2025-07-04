using transport.domain.core;
using transport.domain.core.Mechanical;
using transport.domain.core.Mechanical.modules.Petrol;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Mappers;

public static class PetrolMapper
{
    public static Petrol<FuelType, WagonEntity> ToDomain(PetrolEntity petrol)
    {
        var metaData = new ModuleMetaData<WagonEntity>(petrol.Id, petrol.Name, petrol.CompatibleTransports);
        var specification = new PetrolSpecification(petrol.Capacity);
        return new Petrol<FuelType, WagonEntity>(metaData, specification, FuelType.Diesel);
    }
    
    public static PetrolEntity ToModel(Petrol<FuelType, WagonEntity> petrol)
    {
        return new PetrolEntity()
        {
            Name = petrol.MetaData.Name,
            CompatibleTransports = petrol.MetaData.CompatiblyTransports,
            Capacity = petrol.Specification.Capacity,
        };
    }
}