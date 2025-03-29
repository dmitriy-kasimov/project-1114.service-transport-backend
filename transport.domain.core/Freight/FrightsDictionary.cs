using transport.domain.core.Freight.Modules.Axis;
using transport.domain.core.Freight.Modules.Battery;
using transport.domain.core.Freight.Modules.Engine;
using transport.domain.core.Freight.Modules.Petrol;

namespace transport.domain.core.Freight;

public static class FrightsDictionary
{
    public static Dictionary<FreightIds, Freight> GetFreightById = new Dictionary<FreightIds, Freight>()
    {
        {
            FreightIds.Hauler,
            new Freight("Hauler", "This is a first truck",
                [AxisIds.StH1], AxisDictionary.GetAxisById[AxisIds.StH1],
                [EngineIds.StH1], EngineDictionary.GetPetrolById[EngineIds.StH1],
                [PetrolIds.StH1], PetrolDictionary.GetPetrolById[PetrolIds.StH1],
                [BatteryIds.StH1], BatteryDictionary.GetBatteryById[BatteryIds.StH1]
            )
        },
        {
            FreightIds.Hauler2,
            new Freight("Hauler 2", "This is a second truck that has full stock modules",
                [AxisIds.StH1, AxisIds.StH2], AxisDictionary.GetAxisById[AxisIds.StH1],
                [EngineIds.StH1, EngineIds.StH2], EngineDictionary.GetPetrolById[EngineIds.StH1],
                [PetrolIds.StH1, PetrolIds.StH2], PetrolDictionary.GetPetrolById[PetrolIds.StH1],
                [BatteryIds.StH1, BatteryIds.StH2], BatteryDictionary.GetBatteryById[BatteryIds.StH1]
            )
        },
    };
}