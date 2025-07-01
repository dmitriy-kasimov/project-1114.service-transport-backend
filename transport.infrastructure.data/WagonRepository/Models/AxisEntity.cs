using transport.domain.core.Overland;

namespace transport.infrastructure.data.WagonRepository.Models;

public class AxisEntity
{
    public Guid Id { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Name { get; set;} = string.Empty;
    public AxisVariant Axis { get; set; } = default!;
    // хранить список совместимых тс
}