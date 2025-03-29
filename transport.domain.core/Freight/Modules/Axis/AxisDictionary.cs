namespace transport.domain.core.Freight.Modules.Axis;

public static class AxisDictionary
{
    public static readonly Dictionary<AxisIds, Axis> GetAxisById = new Dictionary<AxisIds, Axis>()
    {
        { AxisIds.StH1, new Axis("St. Axis H-1",
            "This is a stock axis for Hauler-1 with capacity equals 20.0 tons",
            [FreightIds.Hauler, FreightIds.Hauler2],
            AxisType.Three,
            20.0f) 
        },
        { AxisIds.StH2, new Axis("St. Axis H-2",
            "This is a stock axis for Hauler-2 with capacity equals 22.0 tons",
            [FreightIds.Hauler2],
            AxisType.Three,
            20.0f) 
        }
    };

}