namespace transport.domain.core.Truck.Modules.Petrol;

public static class PetrolDictionary
{
    public static readonly Dictionary<PetrolModels, Petrol> GetPetrolByModel = new Dictionary<PetrolModels, Petrol>()
    {
        { PetrolModels.StH1, new Petrol("St. Axis H-1",
            "This is a stock petrol for Hauler-1 with capacity equals 150 l.",
            [TruckModels.Hauler, TruckModels.Hauler2],
            150.0f) 
        },
        { PetrolModels.StH2, new Petrol("St. Axis H-2",
            "This is a stock axis for Hauler-2 with capacity equals 180 l.",
            [TruckModels.Hauler2],
            180.0f) 
        }
    };

}