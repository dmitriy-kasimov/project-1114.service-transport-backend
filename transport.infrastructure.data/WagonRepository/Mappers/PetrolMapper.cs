using transport.domain.core;
using transport.domain.core.Mechanical;
using transport.domain.core.Mechanical.modules.Petrol;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Mappers;

public static class PetrolMapper
{
    public static Petrol<FuelType, domain.core.Wagon.Models> ToDomain(PetrolEntity petrol)
    {
        var metaData = new ModuleMetaData<domain.core.Wagon.Models>(petrol.Model, petrol.Name, petrol.CompatibleTransports);
        var specification = new PetrolSpecification(petrol.Capacity);
        return new Petrol<FuelType, domain.core.Wagon.Models>(metaData, specification, FuelType.Diesel);
    }
    
    public static PetrolEntity ToModel(Petrol<FuelType, domain.core.Wagon.Models> petrol)
    {
        return new PetrolEntity()
        {
            Model = petrol.MetaData.Model,
            Name = petrol.MetaData.Name,
            CompatibleTransports = petrol.MetaData.CompatiblyTransports,
            Capacity = petrol.Specification.Capacity,
        };
    }
}