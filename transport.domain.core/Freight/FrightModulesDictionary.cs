using transport.domain.core.Freight.Modules;
using transport.domain.core.Freight.Modules.Axis;
using transport.domain.core.Freight.Modules.Battery;
using transport.domain.core.Freight.Modules.Engine;
using transport.domain.core.Freight.Modules.Petrol;

namespace transport.domain.core.Freight;

public static class FrightModulesDictionary
{
    public static readonly Dictionary<FreightIds, FreightModules> GetById = new Dictionary<FreightIds, FreightModules>()
    {
        {
            FreightIds.Hauler,
            new FreightModules(
                [AxisIds.StH1], AxisDictionary.GetAxisById[AxisIds.StH1],
                [EngineIds.StH1], EngineDictionary.GetPetrolById[EngineIds.StH1],
                [PetrolIds.StH1], PetrolDictionary.GetPetrolById[PetrolIds.StH1],
                [BatteryIds.StH1], BatteryDictionary.GetBatteryById[BatteryIds.StH1]
            )
        },
        {
            FreightIds.Hauler2,
            new FreightModules(
                [AxisIds.StH1, AxisIds.StH2], AxisDictionary.GetAxisById[AxisIds.StH1],
                [EngineIds.StH1, EngineIds.StH2], EngineDictionary.GetPetrolById[EngineIds.StH1],
                [PetrolIds.StH1, PetrolIds.StH2], PetrolDictionary.GetPetrolById[PetrolIds.StH1],
                [BatteryIds.StH1, BatteryIds.StH2], BatteryDictionary.GetBatteryById[BatteryIds.StH1]
            )
        },
    };
}