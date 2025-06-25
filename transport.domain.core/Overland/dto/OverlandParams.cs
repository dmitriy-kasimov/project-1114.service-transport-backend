using transport.domain.core.Overland.modules;
using transport.domain.core.Overland.modules.Axis;

namespace transport.domain.core.Overland.dto;

public class OverlandParams<TA>(Axis<TA> axis)
{
    private Axis<TA> _axis = axis;
}