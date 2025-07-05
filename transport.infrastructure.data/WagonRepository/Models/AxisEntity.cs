using transport.domain.core.Overland;

namespace transport.infrastructure.data.WagonRepository.Models;

public class AxisEntity
{
    public string Name { get; set;} = string.Empty;
    public AxisVariant Axis { get; set; } = default!;
    
    public List<WagonEntity> CompatibleTransports { get; set; } = [];
    // хранить список совместимых тс
}