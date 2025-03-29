namespace transport.domain.core.Freight.Modules.Battery;

public static class BatteryDictionary
{
    public static Dictionary<BatteryIds, Battery> GetPetrolById = new Dictionary<BatteryIds, Battery>()
    {
        { BatteryIds.StH1, new Battery("St. Axis H-1",
            "This is a stock petrol for Hauler-1 with capacity equals 60 A",
            [FreightModels.Hauler, FreightModels.Hauler2],
            60.0f) 
        },
        { BatteryIds.StH2, new Battery("St. Axis H-2",
            "This is a stock battery for Hauler-2 with capacity equals 80 A",
            [FreightModels.Hauler2],
            80.0f) 
        }
    };

}