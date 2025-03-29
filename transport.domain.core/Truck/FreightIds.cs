using AltV.Net;
using AltV.Net.Enums;

namespace transport.domain.core.Truck;

public enum TrucksIds
{
    Hauler,
    Hauler2
}

public static class FreightsDictionary
{
    public static readonly Dictionary<TrucksIds, VehicleModel> GetAltModelByFrightId =
        new Dictionary<TrucksIds, VehicleModel>()
        {
            { TrucksIds.Hauler, VehicleModel.Hauler },
            { TrucksIds.Hauler2, VehicleModel.Hauler2 },
        };
}