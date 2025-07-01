using transport.domain.core.Mechanical;

namespace transport.infrastructure.data.WagonRepository.Models;

public class EngineEntity
{
    public Guid Id { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Name { get; set;} = string.Empty;
    public decimal Bsfc { get; set;} = decimal.Zero;
    public List<FuelType> AcceptedTypesFuel { get; set; } = [];
    
    public List<WagonEntity> CompatibleModels { get; set; } = [];
    // хранить список совместимых тс
}