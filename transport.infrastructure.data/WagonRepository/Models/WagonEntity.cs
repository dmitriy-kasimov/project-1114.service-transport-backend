using transport.domain.core.Mechanical;

namespace transport.infrastructure.data.WagonRepository.Models;

public class WagonEntity
{
    public Guid Id { get; set; }
    public domain.core.Wagon.Models Model { get; set; }

    public List<EngineEntity> CompatibleEngines { get; set; } = [];
}