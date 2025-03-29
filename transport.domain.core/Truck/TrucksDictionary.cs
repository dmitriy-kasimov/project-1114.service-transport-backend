using AltV.Net.Enums;

namespace transport.domain.core.Truck;

public static class TrucksDictionary
{
    public static readonly Dictionary<TruckModels, VehicleModel> GetAltModelByTruckModel =
        new Dictionary<TruckModels, VehicleModel>()
        {
            { TruckModels.Hauler, VehicleModel.Hauler },
            { TruckModels.Hauler2, VehicleModel.Hauler2 },
        };
}