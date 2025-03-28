namespace transport.domain.core.Truck.Modules.Battery;

public static class BatteryDictionary
{
    public static readonly Dictionary<BatteryModels, Battery> GetBatteryByModel = new Dictionary<BatteryModels, Battery>()
    {
        { BatteryModels.StH1, new Battery("St. Axis H-1",
            "This is a stock petrol for Hauler-1 with capacity equals 60 A",
            [TruckModels.Hauler, TruckModels.Hauler2],
            60.0f) 
        },
        { BatteryModels.StH2, new Battery("St. Axis H-2",
            "This is a stock battery for Hauler-2 with capacity equals 80 A",
            [TruckModels.Hauler2],
            80.0f) 
        }
    };

}