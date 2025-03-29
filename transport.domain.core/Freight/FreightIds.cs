using AltV.Net;
using AltV.Net.Enums;

namespace transport.domain.core.Freight;

public enum FreightIds
{
    Hauler,
    Hauler2
}

public static class FreightsDictionary
{
    public static readonly Dictionary<FreightIds, VehicleModel> GetAltModelByFrightId =
        new Dictionary<FreightIds, VehicleModel>()
        {
            { FreightIds.Hauler, VehicleModel.Hauler },
            { FreightIds.Hauler2, VehicleModel.Hauler2 },
        };
}