using transport.domain.core.Truck.Modules;
using transport.domain.core.Truck.Modules.Axis;
using transport.domain.core.Truck.Modules.Battery;
using transport.domain.core.Truck.Modules.Engine;
using transport.domain.core.Truck.Modules.Petrol;

namespace transport.domain.core.Truck;

public static class TruckModulesDictionary
{
    public static readonly Dictionary<TrucksIds, TruckModules> GetById = new Dictionary<TrucksIds, TruckModules>()
    {
        {
            TrucksIds.Hauler,
            new TruckModules(
                [AxisIds.StH1], AxisDictionary.GetAxisById[AxisIds.StH1],
                [EngineIds.StH1], EngineDictionary.GetPetrolById[EngineIds.StH1],
                [PetrolIds.StH1], PetrolDictionary.GetPetrolById[PetrolIds.StH1],
                [BatteryIds.StH1], BatteryDictionary.GetBatteryById[BatteryIds.StH1]
            )
        },
        {
            TrucksIds.Hauler2,
            new TruckModules(
                [AxisIds.StH1, AxisIds.StH2], AxisDictionary.GetAxisById[AxisIds.StH1],
                [EngineIds.StH1, EngineIds.StH2], EngineDictionary.GetPetrolById[EngineIds.StH1],
                [PetrolIds.StH1, PetrolIds.StH2], PetrolDictionary.GetPetrolById[PetrolIds.StH1],
                [BatteryIds.StH1, BatteryIds.StH2], BatteryDictionary.GetBatteryById[BatteryIds.StH1]
            )
        },
    };
}