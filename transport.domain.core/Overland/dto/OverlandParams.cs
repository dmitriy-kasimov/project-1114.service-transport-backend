using transport.domain.core.Overland.components;

namespace transport.domain.core.Overland.dto;

public abstract class OverlandParams(Axis axis)
{
    private Axis _axis = axis;
}