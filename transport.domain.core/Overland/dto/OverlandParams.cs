using transport.domain.core.Overland.modules;

namespace transport.domain.core.Overland.dto;

public abstract class OverlandParams(Axis axis)
{
    private Axis _axis = axis;
}