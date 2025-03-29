namespace transport.domain.core.Truck.Modules.Axis;

public static class AxisDictionary
{
    public static readonly Dictionary<AxisModels, Axis> GetAxisByModel = new Dictionary<AxisModels, Axis>()
    {
        { AxisModels.StH1, new Axis("St. Axis H-1",
            "This is a stock axis for Hauler-1 with capacity equals 20.0 tons",
            [TruckModels.Hauler, TruckModels.Hauler2],
            AxisType.Three,
            20.0f) 
        },
        { AxisModels.StH2, new Axis("St. Axis H-2",
            "This is a stock axis for Hauler-2 with capacity equals 22.0 tons",
            [TruckModels.Hauler2],
            AxisType.Three,
            20.0f) 
        }
    };

}