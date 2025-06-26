using transport.domain.core.Overland.modules;
using transport.domain.core.Overland.modules.Axis;

namespace transport.domain.core.Overland.dto;

public class OverlandParams<TA>(Axis<TA> axis)
{
    public Axis<TA> Axis => axis;
}