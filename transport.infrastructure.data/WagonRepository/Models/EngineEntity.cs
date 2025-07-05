using transport.domain.core.Mechanical;

namespace transport.infrastructure.data.WagonRepository.Models;

public class EngineEntity
{
    public string Name { get; set;} = string.Empty;
    public decimal Bsfc { get; set;} = decimal.Zero;
    public List<FuelType> AcceptedTypesFuel { get; set; } = [];
    
    public List<WagonEntity> CompatibleTransports { get; set; } = [];
}