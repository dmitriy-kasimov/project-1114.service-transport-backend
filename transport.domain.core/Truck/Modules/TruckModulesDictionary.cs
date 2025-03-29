using transport.domain.core.Truck.Modules.Axis;
using transport.domain.core.Truck.Modules.Battery;
using transport.domain.core.Truck.Modules.Engine;
using transport.domain.core.Truck.Modules.Petrol;

namespace transport.domain.core.Truck.Modules;

public static class TruckModulesDictionary
{
    public static readonly Dictionary<TruckModels, TruckModules> GetByModel = new Dictionary<TruckModels, TruckModules>()
    {
        {
            TruckModels.Hauler,
            new TruckModules(
                [AxisModels.StH1], AxisDictionary.GetAxisByModel[AxisModels.StH1],
                [EngineModels.StH1], EngineDictionary.GetPetrolByModel[EngineModels.StH1],
                [PetrolModels.StH1], PetrolDictionary.GetPetrolByModel[PetrolModels.StH1],
                [BatteryModels.StH1], BatteryDictionary.GetBatteryByModel[BatteryModels.StH1]
            )
        },
        {
            TruckModels.Hauler2,
            new TruckModules(
                [AxisModels.StH1, AxisModels.StH2], AxisDictionary.GetAxisByModel[AxisModels.StH1],
                [EngineModels.StH1, EngineModels.StH2], EngineDictionary.GetPetrolByModel[EngineModels.StH1],
                [PetrolModels.StH1, PetrolModels.StH2], PetrolDictionary.GetPetrolByModel[PetrolModels.StH1],
                [BatteryModels.StH1, BatteryModels.StH2], BatteryDictionary.GetBatteryByModel[BatteryModels.StH1]
            )
        },
    };
}