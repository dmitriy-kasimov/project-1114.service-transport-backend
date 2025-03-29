namespace transport.domain.core.Truck.Modules.Engine;

public static class EngineDictionary
{
    public static readonly Dictionary<EngineModels, Engine> GetPetrolByModel = new Dictionary<EngineModels, Engine>()
    {
        { EngineModels.StH1, new Engine("St. Axis H-1",
            "This is a stock engine for Hauler-1 on fuel type of diesel and 80.",
            [TruckModels.Hauler, TruckModels.Hauler2],
            [TypeFuel.FuelDiesel, TypeFuel.Fuel80]) 
        },
        { EngineModels.StH2, new Engine("St. Axis H-2",
            "This is a stock engine for Hauler-2 on fuel type of diesel and 80.",
            [TruckModels.Hauler2],
            [TypeFuel.FuelDiesel, TypeFuel.Fuel80]) 
        }
    };

}