namespace transport.domain.core.Freight.Modules.Engine;

public static class EngineDictionary
{
    public static Dictionary<EngineIds, Engine> GetPetrolById = new Dictionary<EngineIds, Engine>()
    {
        { EngineIds.StH1, new Engine("St. Axis H-1",
            "This is a stock engine for Hauler-1 on fuel type of diesel and 80.",
            [FreightIds.Hauler, FreightIds.Hauler2],
            [TypeFuel.FuelDiesel, TypeFuel.Fuel80]) 
        },
        { EngineIds.StH2, new Engine("St. Axis H-2",
            "This is a stock engine for Hauler-2 on fuel type of diesel and 80.",
            [FreightIds.Hauler2],
            [TypeFuel.FuelDiesel, TypeFuel.Fuel80]) 
        }
    };

}