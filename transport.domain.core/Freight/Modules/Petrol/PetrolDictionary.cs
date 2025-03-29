using transport.domain.core.Freight;
using transport.domain.core.Freight.Modules.Axis;
using transport.domain.core.Freight.Modules.Petrol;

public static class PetrolDictionary
{
    public static Dictionary<PetrolIds, Petrol> GetPetrolById = new Dictionary<PetrolIds, Petrol>()
    {
        { PetrolIds.StH1, new Petrol("St. Axis H-1",
            "This is a stock petrol for Hauler-1 with capacity equals 150 l.",
            [FreightModels.Hauler, FreightModels.Hauler2],
            150.0f) 
        },
        { PetrolIds.StH2, new Petrol("St. Axis H-2",
            "This is a stock axis for Hauler-2 with capacity equals 180 l.",
            [FreightModels.Hauler2],
            180.0f) 
        }
    };

}