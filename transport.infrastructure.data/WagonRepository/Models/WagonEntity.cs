using transport.domain.core.Mechanical;

namespace transport.infrastructure.data.WagonRepository.Models;

public class WagonEntity
{
    public Guid Id { get; set; }
    public domain.core.Wagon.Models Model { get; set; }

    public List<string> CompatibleEngines { get; set; } = [];
    public List<string> CompatiblePetrol { get; set; } = [];
    public List<string> CompatibleAxis { get; set; } = [];
    public List<string> CompatibleBatteries { get; set; } = [];
    
    // many 2 many for each module
    public List<EngineEntity> CompatibleWagonEngines { get; set; } = [];
    public EngineEntity DefaultWagonEngine { get; set; }
    public List<AxisEntity> CompatibleWagonAxis { get; set; } = [];
    public AxisEntity DefaultWagonAxis { get; set; }
    public List<PetrolEntity> CompatibleWagonPetrol { get; set; } = [];
    public PetrolEntity DefaultWagonPetrol { get; set; }
    public List<BatteryEntity> CompatibleWagonBatteries { get; set; } = [];
    public BatteryEntity DefaultWagonBattery { get; set; }
}
