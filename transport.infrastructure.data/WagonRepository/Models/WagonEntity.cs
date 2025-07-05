using transport.domain.core.Mechanical;

namespace transport.infrastructure.data.WagonRepository.Models;

public class WagonEntity
{
    public domain.core.Wagon.Models Model { get; set; }

    // public List<string> CompatibleEngines { get; set; } = [];
    // public List<string> CompatiblePetrol { get; set; } = [];
    // public List<string> CompatibleAxis { get; set; } = [];
    // public List<string> CompatibleBatteries { get; set; } = [];
    
    // many 2 many for each module
    public List<EngineEntity> CompatibleEngines { get; set; } = [];
    public List<AxisEntity> CompatibleAxis { get; set; } = [];
    public List<PetrolEntity> CompatiblePetrol { get; set; } = [];
    public List<BatteryEntity> CompatibleBatteries { get; set; } = [];
}
