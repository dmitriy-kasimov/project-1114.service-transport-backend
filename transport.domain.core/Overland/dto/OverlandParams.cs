using transport.domain.core.Overland.modules;
using transport.domain.core.Overland.modules.Axis;

namespace transport.domain.core.Overland.dto;

public class OverlandParams<TA>(string id, string name, Axis<TA> axis) : IEntity
{
    public string Id => id;
    public string Name => name;
    
    private Axis<TA> _axis = axis;
}