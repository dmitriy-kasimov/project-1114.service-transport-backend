using transport.domain.core.Freight;
using transport.domain.core.Freight.Modules.Axis;

public static class AxisFactory
{
    public static Dictionary<AxisModels, Axis> GetAxisById = new Dictionary<AxisModels, Axis>()
    {
        { AxisModels.Hauler1, new Axis("St. Axis H-1",
            "This is a stock axis for Hauler-1 with capacity equals 20.0 tons",
            [FreightModels.Hauler, FreightModels.Hauler2],
            AxisType.Three,
            20.0f) 
        },
        { AxisModels.Hauler2, new Axis("St. Axis H-2",
            "This is a stock axis for Hauler-2 with capacity equals 22.0 tons",
            [FreightModels.Hauler2],
            AxisType.Three,
            20.0f) 
        }
    };

}