using transport.domain.core.Overland.modules;
using transport.domain.core.Overland.modules.Axis;

namespace transport.domain.core.Overland.dto;

public class OverlandParams<T, TA>(Axis<T, TA> axis)
{
    public Axis<T, TA> Axis => axis;
}